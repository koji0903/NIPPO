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
    public partial class MonthlyReportWindow : Form
    {
        private MonthlyReport _mr;
        private int _year;

        public MonthlyReportWindow()
        {
            InitializeComponent();
            _mr = new MonthlyReport();
        }

        private void closeWindow_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextMonth_button_Click(object sender, EventArgs e)
        {
        }

        public DialogResult ShowDialog(int year)
        {
            _year = year;
            return base.ShowDialog(); 
        }

        [Obsolete("ShowDialog(year As Int)を使ってください。", true)]
        public new DialogResult ShowDialog(IWin32Window owner)
        {
            _year = 2013; // デフォルト値
            return base.ShowDialog(owner);
        }

        [Obsolete("ShowDialog(year As Int)を使ってください。", true)]
        public new DialogResult ShowDialog()
        {
            return base.ShowDialog();
        }

    }
}
