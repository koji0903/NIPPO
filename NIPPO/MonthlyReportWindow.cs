﻿using System;
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

        public MonthlyReportWindow()
        {
            InitializeComponent();
        }

        private void closeWindow_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextMonth_button_Click(object sender, EventArgs e)
        {
            _mr.incrMonth();
            // 再描画
            this.reloadWindow();
        }

        private void prevMonth_button_Click(object sender, EventArgs e)
        {
            _mr.decrMonth();
            // 再描画
            this.reloadWindow();
        }

        private void reloadWindow()
        {
            // 表示する「年度/月」の作成と表示
            FYMonth_label.Text = _mr.getStringYearMonth();
            // 「>」の有効/無効化
            this.nextMonth_button.Enabled = _mr.existsNextMonth();
            // 「<」の有効/無効化
            this.prevMonth_button.Enabled = _mr.existsPrevMonth();
            // SQLから情報取得と表示

            // 合計時間の計算と、「集計」エリアへの表示

        }

        public DialogResult ShowDialog(int FY)
        {
            this._FY = FY;
            // ロジック部のオブジェクト生成
            _mr = new MonthlyReport(this._FY);
            //MessageBox.Show(this._FY.ToString() + "年度で表示します");
            return base.ShowDialog();
        }

        [Obsolete("ShowDialog(FY As Int)を使ってください。", true)]
        public new DialogResult ShowDialog(IWin32Window owner)
        {
            _FY = 2013; // デフォルト値
            return base.ShowDialog(owner);
        }

        [Obsolete("ShowDialog(FY As Int)を使ってください。", true)]
        public new DialogResult ShowDialog()
        {
            return base.ShowDialog();
        }

        // フォーム表示後に発生するイベント
        private void Me_Shown(object sender, EventArgs e)
        {
            // リロード時のメソッドを流用
            this.reloadWindow();
        }

    }
}
