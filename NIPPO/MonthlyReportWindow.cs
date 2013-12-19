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
        private string _userID;

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
                this.list_dataGridView.DataSource = _mr.getMonthlyWorkReport();
                this.list_dataGridView.DataMember = @"MonthlyReport";
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

        }

        /// <summary>
        /// showDialog()のオーバーロードメソッド
        /// </summary>
        /// <param name="FY">事業年度</param>
        /// <param name="userID">ユーザID</param>
        /// <returns></returns>
        public DialogResult ShowDialog(int FY, string userID)
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

    }
}
