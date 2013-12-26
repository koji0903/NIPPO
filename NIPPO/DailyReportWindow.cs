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
        // DailyReportの処理クラス
        private DailyReport _dr;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="fy"></param>
        /// <param name="user_name"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        public DailyReportWindow(int fy, int userID, int year, int month, int day)
        {
            InitializeComponent();
            _dr = new DailyReport(fy, userID, year, month, day);
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
            this.Calender_Label.Text = _dr.GetDateStr();

            // 勤務情報の初期値設定
            String[] time = _dr.initialWorkTime();
            this.StartTime_Hour_Combobox.Text = time[0];
            this.StartTime_Second_Combobox.Text = time[1];
            this.EndTime_Hour_Combobox.Text = time[2];
            this.EndTime_Second_Combobox.Text = time[3];

            this.Set_WorkTime_Textbox("start");

            // DataGridへの表示
            this.WorkDetail_DateGridView.DataSource = _dr.ds;
            if ( _dr.existTableInDS() )
            {
                this.WorkDetail_DateGridView.DataMember = "work_detail";
            }

            // 作業合計時間の表示                    
            this.TotalWorkTime_Textbox.Text = _dr.setHourText(_dr.getTotalWorkTime());
        }


        /// <summary>
        /// "勤務開始時刻"の"時"の指定が変わった時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartTime_Hour_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Set_WorkTime_Textbox("start");
        }


        /// <summary>
        /// "勤務開始時刻"の"分"の指定が変わった時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartTime_Second_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Set_WorkTime_Textbox("start");
        }

        /// <summary>
        /// "勤務終了時刻"の"時"の指定が変わった時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndTime_Hour_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Set_WorkTime_Textbox("end");
        }

        /// <summary>
        /// "勤務終了時刻"の"分"の指定が変わった時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndTime_Second_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Set_WorkTime_Textbox("end");
        }

        /// <summary>
        /// 勤務開始時間（時、分）、勤務終了時間（時、分）の値が変わった場合に、データを自動取得して、
        /// 勤務時間を計算(☆日にちをまたいているときに不具合あり)
        /// </summary>
        private void Set_WorkTime_Textbox(String str)
        {
            // Textフィールドに値を表示
            if ( _dr.judgementTime(
                    int.Parse(this.StartTime_Hour_Combobox.Text),
                    int.Parse(this.StartTime_Second_Combobox.Text),
                    int.Parse(this.EndTime_Hour_Combobox.Text),
                    int.Parse(this.EndTime_Second_Combobox.Text)) == false )
            {
                // 時間に矛盾が生じている場合は強制的に値を変更する
                switch (str)
                {
                    case "start":
                        // 終了時間に上書き
                        this.StartTime_Hour_Combobox.Text = this.EndTime_Hour_Combobox.Text;
                        this.StartTime_Second_Combobox.Text = this.EndTime_Second_Combobox.Text;
                        break;
                    case "end":
                        // 開始時間に上書き
                        this.EndTime_Hour_Combobox.Text = this.StartTime_Hour_Combobox.Text;
                        this.EndTime_Second_Combobox.Text = this.EndTime_Second_Combobox.Text;
                        break;
                }

            }

            // 時間の計算
            Double[] time = _dr.GetWorkTime_str(
                this.StartTime_Hour_Combobox.Text,
                this.StartTime_Second_Combobox.Text,
                this.EndTime_Hour_Combobox.Text,
                this.EndTime_Second_Combobox.Text
                );
   

            this.WorkTime_Textbox.Text = _dr.setHourText(time[0]);
            this.RestTime_Textbox.Text = _dr.setHourText(time[1]);
            this.NormalOverTime_Textbox.Text = _dr.setHourText(time[2]);
            this.NightOverTime_Textbox.Text = _dr.setHourText(time[3]);
        }

        /// <summary>
        /// プロジェクト「選択」ボタンクリック時の動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerarchProject_Button_Click(object sender, EventArgs e)
        {

            using ( SearchProjectsWindow _spw = new SearchProjectsWindow( year ) )
            {
                _spw.ShowDialog(this);
                this.project_ID = _spw._project_id;
                _dr.project_ID = data_access.getProjectID(project_num);
                this.ProjectName_Textbox.Text = _spw._project_name;             
            }
           
        //    using (DataAccessClass data_access = new DataAccessClass())
        //    {
        //        int project_num = 10;
        //        // Task IDのセット
        //        this.project_ID = data_access.getProjectID(project_num);
        //    }
        //    this.ProjectCode_Textbox.Text = "1234";
        //    this.ProjectName_Textbox.Text = "テスト用プロジェクト";
        }

        /// <summary>
        /// 業務「選択」ボタンクリック時の動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBusiness_Button_Click(object sender, EventArgs e)
        {
            // 業務選択を行うウィンドウを表示
            using (SearchTasksWindow _stw = new SearchTasksWindow() )
            {
                _stw.ShowDialog(this);
                this.task_ID = _stw._taskid;
                this.TaskCode_Textbox.Text = _stw._taskcode;
                this.TaskName_TextBox.Text = _stw._taskname;             
            }
            
         //  using (DataAccessClass data_access = new DataAccessClass())
         //  {
         //      int task_code = 10;
         //      // Task IDのセット
         //      this.task_ID = data_access.getProjectID(task_code);
         //  }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkDetail_DateGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// GUI上の"×"ボタンをクリックした時のアクション（テーブル上の選択した行を削除する）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "データを削除します。よろしいですか？",
                "確認",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);
            // カーソル行のデータを削除（フラグたて）し、データセットを更新
            if (result == DialogResult.OK)
            {
                this._dr.deleteRow(WorkDetail_DateGridView.CurrentCell.RowIndex);
            }
        }

        /// <summary>
        /// GUI上の"↑"ボタンをクリックした時のアクション（”業務詳細入力”に記載された情報をテーブルに追加する）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Button_Click(object sender, EventArgs e)
        {
            _dr.add_action(
                this.ProjectName_Textbox.Text.ToString(),
                this.TaskName_TextBox.Text.ToString(),
                this.Description_Textbox.Text,
                this.WokTime_DomainUpDown.Text
                );
            // 作業合計時間の表示                    
            this.TotalWorkTime_Textbox.Text = _dr.setHourText(_dr.getTotalWorkTime());
        }

        /// <summary>
        /// 「登録」ボタンクリック時の動作設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Regist_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = _dr.regist_action(
                    this.StartTime_Hour_Combobox.Text,
                    this.StartTime_Second_Combobox.Text,
                    this.EndTime_Hour_Combobox.Text,
                    this.EndTime_Second_Combobox.Text
                    );
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
            if (_dr.DataSetCompare("work_detail"))
            {
                // 更新がない場合は、確認なしでそのままWindowクローズ
                this.Close();
            }
            else
            {
                // 異なる場合はメッセージウィンドウ表示
                DialogResult result = MessageBox.Show(
                    "更新内容は反映されませんがよろしいですか？",
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
