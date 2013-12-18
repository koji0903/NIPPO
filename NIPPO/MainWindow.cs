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
        private string userID;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            using (LoginWindow _lw = new LoginWindow())
            {
                if (_lw.ShowDialog(this) == DialogResult.OK)
                {
                    this.userID = _lw.userID;
                }
                else
                {
                    // LoginWindowが[×]ボタンで閉じられた場合。
                    this.Close();
                }
            }

        }

        private void コード発行_Click(object sender, EventArgs e)
        {

        }

        private void DalyReport_Click(object sender, EventArgs e)
        {

        }
    }
}
