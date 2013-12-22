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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void コード発行_Click(object sender, EventArgs e)
        {

        }

        private void DailyReport_Click(object sender, EventArgs e)
        {
            DailyReportWindow daily_report_window = new DailyReportWindow(2013,1,2013,12,14);
            daily_report_window.ShowDialog(this);
            daily_report_window.Dispose();
        }
    }
}
