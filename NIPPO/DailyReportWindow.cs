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
        public DailyReportWindow()
        {
            InitializeComponent();
        }

        private void DailyReportWindow_Load(object sender, EventArgs e)
        {
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
