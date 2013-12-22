using System;
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
        private int userID, year, month, day;
        private DataSet ds;
        // 業務詳細に表示されているプロジェクト、業務のデータベースID
        private int project_ID, task_ID;

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
        }

        /// <summary>
        /// DailyReportウィンドウが表示された際に自動実行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DailyReportWindow_Load(object sender, EventArgs e)
        {
            // 年月日情報の表示
            using (DailyReport daily = new DailyReport())
            {
                this.Calender_Label.Text = daily.GetDateStr(this.year, this.month, this.day);
            }
            // データベースへのアクセスはここで
            using (DataAccessClass data_access = new DataAccessClass())
            {
                ds = data_access.GetWorkDetailDs("1", this.year, this.month, this.day);
            }
        }


        private void DailyReportWindow_Shown(object sender, EventArgs e)
        {
               // DataGridへの表示
               this.WorkDetail_DateGridView.DataSource = ds;
               if (ds.Tables.Count != 0)
               {
                   this.WorkDetail_DateGridView.DataMember = "WorkDetail";
               }
               // 作業合計時間の表示                    
            using (DailyReport daily = new DailyReport())
            {
               this.TotalWorkTime_Textbox.Text = daily.getTotalWorkTime(ds).ToString("F2") + "h";                     
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
            double tmp;
            tmp = time[0];
            this.WorkTime_Textbox.Text = time[0].ToString("F2") + "h";
            this.RestTime_Textbox.Text = time[1].ToString("F2") + "h";
            this.NormalOverTime_Textbox.Text = time[2].ToString("F2") + "h";
            this.NightOverTime_Textbox.Text = time[3].ToString("F2") + "h";
        }


        private void SerarchProject_Button_Click(object sender, EventArgs e)
        {
            // プロジェクトの選択を行うウィンドウを表示
            int project_num = 10;
            this.ProjectCode_Textbox.Text = "1234";
            this.ProjectName_Textbox.Text = "テスト用プロジェクト";
        }

        private void SearchBusiness_Button_Click(object sender, EventArgs e)
        {
            // 業務選択を行うウィンドウを表示
            int task_code = 10;
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
            int row_num = WorkDetail_DateGridView.CurrentCell.RowIndex;
            int j = 0;
            for (int i = 0; i < ds.Tables["WorkDetail"].Rows.Count; i++)
            {
                if (ds.Tables["WorkDetail"].Rows[i].RowState != DataRowState.Deleted)
                {
                    // 削除されていない
                    if (row_num == j)
                    {
                        ds.Tables["WorkDetail"].Rows[i].Delete();
                        break;
                    }
                    j++;
                }
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
            dt.Rows.Add(dr);
        }



    }
}
