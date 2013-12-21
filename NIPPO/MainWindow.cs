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
        private int id;
        private int _year;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // 現在の年度を設定
            _year = DateTime.Now.Year;
            FY_numericUpDown.Value = _year;
            
            using (LoginWindow _lw = new LoginWindow())
            {
                if (_lw.ShowDialog(this) == DialogResult.OK)
                {
                    this.id = _lw.id;
                }
                else
                {
                    // LoginWindowが[×]ボタンで閉じられた場合。
                    this.Close();
                }
            }
            // ステータスバーにログイン名表示（とりあえずIDだけ。氏名の表示は後で。）
            // （shownイベントでやったほうがいいかも）
            user_toolStripStatusLabel.Text = this.id.ToString();
        }

        private void コード発行_Click(object sender, EventArgs e)
        {

        }

        private void DalyReport_Click(object sender, EventArgs e)
        {
            using (MonthlyReportWindow _form = new MonthlyReportWindow())
            {
                _form.ShowDialog(this._year, this.id);
            }
        }

        private void ViewWorkRecord_button_Click(object sender, EventArgs e)
        {
            using (MonthlyReportWindow _form = new MonthlyReportWindow())
            {
                _form.ShowDialog(this._year, this.id);
            }
        }

        private void FY_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this._year = (int)FY_numericUpDown.Value;
            // MessageBox.Show(_year.ToString()); // debug
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
