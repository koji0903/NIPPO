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
        private int _FY;
        private int _userID;

        public MonthlyReportWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「終了」ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeWindow_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 「>」ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextMonth_button_Click(object sender, EventArgs e)
        {
            _mr.incrMonth();
            // 再描画
            this.reloadWindow();
        }

        /// <summary>
        /// 「<」ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prevMonth_button_Click(object sender, EventArgs e)
        {
            _mr.decrMonth();
            // 再描画
            this.reloadWindow();
        }

        /// <summary>
        /// ウィンドウを再描画する
        /// </summary>
        private void reloadWindow()
        {
            // ステータスバー表示
            // (月を切り替えるごとにSQL問い合わせは無駄だが...)
            user_toolStripStatusLabel.Text = _mr.getUserName();
            // 表示する「年度/月」の作成と表示
            FYMonth_label.Text = _mr.getStringYearMonth();
            // 「>」の有効/無効化
            this.nextMonth_button.Enabled = _mr.existsNextMonth();
            // 「<」の有効/無効化
            this.prevMonth_button.Enabled = _mr.existsPrevMonth();
            // SQLから情報取得と表示
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataSet _ds = _mr.getMonthlyWorkReport();
                this.list_dataGridView.DataSource = _ds;
                this.list_dataGridView.DataMember = _mr.getListTableName();
                // 祝日の色付け
                fillColorHoridayRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
            // 合計時間の計算と、「集計」エリアへの表示
            this.totalTime_textBox.Text = _mr.getTotalTimeText();
            this.totalOverTime125_textBox.Text = _mr.getTotalOverTime125Text();
            this.totalOverTime150_textBox.Text = _mr.getTotalOverTime150Text();
        }

        public void fillColorHoridayRows()
        {
            DataSet ds = null;
            try
            {
                ds = _mr.getHolidayListDs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("holidaysテーブル取得時：" + ex.Message,
                    "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //
            for (int i=0; i < ds.Tables[0].Rows.Count; i++)
            {
                int indexDay = int.Parse(ds.Tables[0].Rows[i]["day"].ToString()) - 1;
                this.list_dataGridView.Rows[indexDay].DefaultCellStyle.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// showDialog()のオーバーロードメソッド
        /// </summary>
        /// <param name="FY">事業年度</param>
        /// <param name="userID">ユーザID</param>
        /// <returns></returns>
        public DialogResult ShowDialog(int FY, int userID)
        {
            this._FY = FY;
            this._userID = userID;
            // ロジック部のオブジェクト生成
            _mr = new MonthlyReport(this._FY, this._userID);
            //MessageBox.Show(this._FY.ToString() + "年度で表示します");
            return base.ShowDialog();
        }

        [Obsolete("ShowDialog(FY As Int, userID As Int)を使ってください。", true)]
        public new DialogResult ShowDialog(IWin32Window owner)
        {
            _FY = 2013; // デフォルト値
            return base.ShowDialog(owner);
        }

        [Obsolete("ShowDialog(FY As Int, userID As Int)を使ってください。", true)]
        public new DialogResult ShowDialog()
        {
            return base.ShowDialog();
        }

        /// <summary>
        /// フォーム表示後に発生するイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Me_Shown(object sender, EventArgs e)
        {
            // リロード時のメソッドを流用
            this.reloadWindow();
        }

        private void list_dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (list_dataGridView.Rows.Count > 0 &&
                list_dataGridView.SelectedRows.Count > 0)
            {
                int index = list_dataGridView.SelectedRows[0].Index;

                using (DailyReportWindow _form = new DailyReportWindow(_FY, this._userID, _mr.getCalYear(), _mr.getMonth(), index + 1))
                {
                    _form.ShowDialog(this);
                    _form.Dispose();
                    this.reloadWindow();
                }
                /*
                MessageBox.Show("DailyReportWindow.showDialog(" + _mr.getCalYear()
                    + "," + _mr.getMonth()
                    + "," + (index + 1)
                    + "," + this._userID.ToString() + ")");
                 */

            }
        }

        private void outputExcel_button_Click(object sender, EventArgs e)
        {
            try
            {
                _mr.outputExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
