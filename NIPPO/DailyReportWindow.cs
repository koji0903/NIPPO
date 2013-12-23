﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NIPPO
{
    public partial class DailyReportWindow : Form
    {
        // 前のウィンドウからの引き付き情報
        private int year, month, day;
        private int userID;
        // WorkDetailテーブル情報
        private DataSet ds, ds_org;
        // 業務詳細に表示されているプロジェクト、業務のデータベースID
        private int project_ID, task_ID;
        // 時間比較用のデータ
        private double work_time, regist_time;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="fy"></param>
        /// <param name="user_name"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        public DailyReportWindow(int fy, int userID, int year, int month, int day )
        {
            InitializeComponent();
            DataSet ds = new DataSet();
            this.userID = userID;
            this.year = year;
            this.month = month;
            this.day = day;
            this.project_ID = 0;
            this.task_ID = 0;

            // 勤務時間（比較用）
            this.work_time = 0.0;
            // 作業登録時間（比較用）
            this.regist_time = 0.0;
        }

        /// <summary>
        /// DailyReportウィンドウのオブジェクト生成時の実行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DailyReportWindow_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// DailyReportウィンドウの情報表示時に実行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DailyReportWindow_Shown(object sender, EventArgs e)
        {
            // 年月日情報の表示
            using (DailyReport daily = new DailyReport())
            {
                this.Calender_Label.Text = daily.GetDateStr(this.year, this.month, this.day);
            }

            // データベースへのアクセスはここで
            using (DataAccessClass data_access = new DataAccessClass())
            {
                ds = data_access.GetWorkDetailDs(this.userID, this.year, this.month, this.day);
                ds_org = ds.Copy();
            }

            // DataGridへの表示
            this.WorkDetail_DateGridView.DataSource = ds;
            if (ds.Tables.Count != 0)
            {
                this.WorkDetail_DateGridView.DataMember = "WorkDetail";
            }

            // 作業合計時間の表示                    
            using (DailyReport daily = new DailyReport())
            {
                this.regist_time = daily.getTotalWorkTime(ds);
                this.TotalWorkTime_Textbox.Text = this.regist_time.ToString("F2") + "h";                     
            }
        }


        /// <summary>
        /// "勤務開始時刻"の"時"の指定が変わった時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartTime_Hour_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Set_WorkTime_Textbox();
        }

        /// <summary>
        /// "勤務開始時刻"の"分"の指定が変わった時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartTime_Second_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Set_WorkTime_Textbox();
        }

        /// <summary>
        /// "勤務終了時刻"の"時"の指定が変わった時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndTime_Hour_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Set_WorkTime_Textbox();
        }

        /// <summary>
        /// "勤務終了時刻"の"分"の指定が変わった時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndTime_Second_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Set_WorkTime_Textbox();
        }

        /// <summary>
        /// 勤務開始時間（時、分）、勤務終了時間（時、分）の値が変わった場合に、データを自動取得して、
        /// 勤務時間を計算
        /// </summary>
        private void Set_WorkTime_Textbox()
        {
            Double[] time = new Double[] { 0.00, 0.00, 0.00, 0.00 };

            using (DailyReport _daily = new DailyReport())
            {
                string start_hour, start_second, end_hour, end_second;
                start_hour = this.StartTime_Hour_Combobox.Text;
                start_second = this.StartTime_Second_Combobox.Text;
                end_hour = this.EndTime_Hour_Combobox.Text;
                end_second = this.EndTime_Second_Combobox.Text;

                // 勤務時間の計算
                time = _daily.GetWorkTime(
                    this.year,
                    this.month,
                    this.day,
                    int.Parse(start_hour),
                    int.Parse(start_second),
                    int.Parse(end_hour),
                    int.Parse(end_second)
                );

            }
            // Textフィールドに値を表示
            this.work_time = time[0];
            this.WorkTime_Textbox.Text = time[0].ToString("F2") + "h";
            this.RestTime_Textbox.Text = time[1].ToString("F2") + "h";
            this.NormalOverTime_Textbox.Text = time[2].ToString("F2") + "h";
            this.NightOverTime_Textbox.Text = time[3].ToString("F2") + "h";
        }

        /// <summary>
        /// プロジェクト「選択」ボタンクリック時の動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerarchProject_Button_Click(object sender, EventArgs e)
        {
            using (DataAccessClass data_access = new DataAccessClass())
            {
                int project_num = 10;
                // Task IDのセット
                this.project_ID = data_access.getProjectID(project_num);
            }
            this.ProjectCode_Textbox.Text = "1234";
            this.ProjectName_Textbox.Text = "テスト用プロジェクト";
        }

        /// <summary>
        /// 業務「選択」ボタンクリック時の動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBusiness_Button_Click(object sender, EventArgs e)
        {
            // 業務選択を行うウィンドウを表示
            using (DataAccessClass data_access = new DataAccessClass())
            {
                int task_code = 10;
                // Task IDのセット
                this.task_ID = data_access.getProjectID(task_code);
            }
            this.TaskCode_Textbox.Text = "5678";
            this.TaskName_TextBox.Text = "テスト用業務";
        }

        private void WorkDetail_DateGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// GUI上の"X"ボタンをクリックした時のアクション（テーブル上の選択した行を削除する）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            // カーソル行の行ナンバーを取得
            using (DailyReport daily = new DailyReport())
            {
                ds = daily.deleteRow(ds, WorkDetail_DateGridView.CurrentCell.RowIndex);
            }
        }

        /// <summary>
        /// GUI上の"↑"ボタンをクリックした時のアクション（”業務詳細入力”に記載された情報をテーブルに追加する）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Button_Click(object sender, EventArgs e)
        {
            // 業務詳細の枠から必要な情報を取得して、データセットを更新
            DataTable dt = ds.Tables["WorkDetail"];
            DataRow dr = dt.NewRow();
            dr["name"] = this.ProjectName_Textbox.Text;
            dr["name1"] = this.TaskName_TextBox.Text;
            dr["note"] = this.Description_Textbox.Text;
            dr["times"] = this.WokTime_DomainUpDown.Text;
            dr["projects_ID"] = this.project_ID;
            dr["tasks_ID"] = this.task_ID;
            using (DataAccessClass data_access = new DataAccessClass())
            {
                dr["work_reports_ID"] = data_access.GetWorkReportID(this.userID, this.year, this.month, this.day);
            }

            if ((string)dr["name"] != "" && (string)dr["name1"] != "" && (double)dr["times"] > 0.0 )
            {
                // データセット更新
                dt.Rows.Add(dr);
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "入力情報が不足しています。",
                    "メッセージ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);
            }

            // 作業合計時間の表示                    
            using (DailyReport daily = new DailyReport())
            {
                this.regist_time = daily.getTotalWorkTime(ds);
                this.TotalWorkTime_Textbox.Text = this.regist_time.ToString("F2") + "h";
            }
        }

        /// <summary>
        /// 「登録」ボタンクリック時の動作設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Regist_Button_Click(object sender, EventArgs e)
        {
            // 勤務時間と、作業割り当て時間の割り振りチェック
            // データベースへの更新作業
            using (DailyReport daily = new DailyReport())
            {
                String ret = daily.timeCompare(this.work_time, this.regist_time);
                if (ret != "")
                {
                    DialogResult res = MessageBox.Show(
                      　ret,
                        "メッセージ",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);
                    //何が選択されたか調べる
                    if (res == DialogResult.Cancel)
                    {
                        return;
                    }

                }

            }

            // データベースへの更新作業
            using (DataAccessClass data_access = new DataAccessClass())
            {
                data_access.Update(ds, "WorkDetail");
            }

            DialogResult result = MessageBox.Show(
                "日報情報を更新しました。",
                "実行完了",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            //何が選択されたか調べる
            if (result == DialogResult.OK)
            {
                //「はい」が選択された時、それ以外の場合は元に戻る
                this.Close();
            }
        }

        
        /// <summary>
        /// 「キャンセル」ボタンクリック時の動作設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            // 更新データがあるかどうかの確認
            using (DailyReport daily = new DailyReport())
            {
                if (daily.DataSetCompare(ds, ds_org, "WorkDetail"))
                {
                    // 更新がない場合は、確認なしでそのままWindowクローズ
                    this.Close();
                }
                else
                {
                    // 異なる場合はメッセージウィンドウ表示
                    DialogResult result = MessageBox.Show(
                        "更新内容は反映されませんが、よろしですか？", 
                        "確認", 
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);

                    //何が選択されたか調べる
                    if (result == DialogResult.OK)
                    {
                        //「はい」が選択された時、それ以外の場合は元に戻る
                        this.Close();
                    }
                }
            }
        }



    }
}
