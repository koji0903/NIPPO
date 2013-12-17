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
        public DailyReportWindow(int fy, string user_name)
        {
            InitializeComponent();
        }

        private void DailyReportWindow_Load(object sender, EventArgs e)
        {
            using (DailyReport _daily = new DailyReport())
            {
                // 年月日情報の表示
                this.Calender_Label.Text = _daily.GetCalender(2013, 12, 13);
            }

            // 勤務日報情報一覧表示
            try
            {
                using (DataAccessClass _proc = new DataAccessClass())
                {
                    this.dataGridView1.AutoGenerateColumns = false;
                    this.dataGridView1.DataSource = null;
                    // DataGridViewオブジェクトにデータセットを入れている処理
                    this.dataGridView1.DataSource = _proc.GetTitleDs("koji","koji","");
                    this.dataGridView1.DataMember = @"UserList";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }

        }
        


    }
}
