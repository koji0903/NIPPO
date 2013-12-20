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
        private int year, month, day;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="fy"></param>
        /// <param name="user_name"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        public DailyReportWindow(int fy, string user_name, int year, int month, int day )
        {
            InitializeComponent();
            this.year = year;
            this.month = month;
            this.day = day;
        }

        /// <summary>
        /// DailyReportウィンドウが表示された際に自動実行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DailyReportWindow_Load(object sender, EventArgs e)
        {

        }


        private void DailyReportWindow_Shown(object sender, EventArgs e)
        {
            using (DailyReport _daily = new DailyReport())
            {
                // 年月日情報の表示
                this.Calender_Label.Text = _daily.GetDateStr(2013, 12, 13);
            }

                using (DataAccessClass data_access = new DataAccessClass())
                {
                    this.WorkDetail_DateGridView.DataSource = data_access.GetWorkDetailDs("0001", 2013, 12, 19, 7.75);
                    this.WorkDetail_DateGridView.DataMember = @"WorkDetail";
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
        }

        private void SearchBusiness_Button_Click(object sender, EventArgs e)
        {
            // 業務選択を行うウィンドウを表示
        }



    }
}
