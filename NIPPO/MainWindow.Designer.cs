﻿namespace NIPPO
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.MainFunctionTab = new System.Windows.Forms.TabControl();
            this.Report_tab = new System.Windows.Forms.TabPage();
            this.View_tab = new System.Windows.Forms.TabPage();
            this.Collect_tab = new System.Windows.Forms.TabPage();
            this.ProjectManage_tab = new System.Windows.Forms.TabPage();
            this.MasterManage_tab = new System.Windows.Forms.TabPage();
            this.DalyReport_button = new System.Windows.Forms.Button();
            this.ViewWorkRecord_button = new System.Windows.Forms.Button();
            this.OutputCSV_button = new System.Windows.Forms.Button();
            this.MainFunctionTab.SuspendLayout();
            this.Report_tab.SuspendLayout();
            this.View_tab.SuspendLayout();
            this.Collect_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFunctionTab
            // 
            this.MainFunctionTab.Controls.Add(this.Report_tab);
            this.MainFunctionTab.Controls.Add(this.View_tab);
            this.MainFunctionTab.Controls.Add(this.Collect_tab);
            this.MainFunctionTab.Controls.Add(this.ProjectManage_tab);
            this.MainFunctionTab.Controls.Add(this.MasterManage_tab);
            this.MainFunctionTab.Location = new System.Drawing.Point(31, 65);
            this.MainFunctionTab.Name = "MainFunctionTab";
            this.MainFunctionTab.SelectedIndex = 0;
            this.MainFunctionTab.Size = new System.Drawing.Size(423, 228);
            this.MainFunctionTab.TabIndex = 0;
            // 
            // Report_tab
            // 
            this.Report_tab.Controls.Add(this.DalyReport_button);
            this.Report_tab.Location = new System.Drawing.Point(4, 22);
            this.Report_tab.Name = "Report_tab";
            this.Report_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Report_tab.Size = new System.Drawing.Size(415, 202);
            this.Report_tab.TabIndex = 0;
            this.Report_tab.Text = "日報入力";
            this.Report_tab.UseVisualStyleBackColor = true;
            // 
            // View_tab
            // 
            this.View_tab.Controls.Add(this.ViewWorkRecord_button);
            this.View_tab.Location = new System.Drawing.Point(4, 22);
            this.View_tab.Name = "View_tab";
            this.View_tab.Padding = new System.Windows.Forms.Padding(3);
            this.View_tab.Size = new System.Drawing.Size(415, 202);
            this.View_tab.TabIndex = 1;
            this.View_tab.Text = "一覧表示";
            this.View_tab.UseVisualStyleBackColor = true;
            // 
            // Collect_tab
            // 
            this.Collect_tab.Controls.Add(this.OutputCSV_button);
            this.Collect_tab.Location = new System.Drawing.Point(4, 22);
            this.Collect_tab.Name = "Collect_tab";
            this.Collect_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Collect_tab.Size = new System.Drawing.Size(415, 202);
            this.Collect_tab.TabIndex = 2;
            this.Collect_tab.Text = "集計";
            this.Collect_tab.UseVisualStyleBackColor = true;
            // 
            // ProjectManage_tab
            // 
            this.ProjectManage_tab.Location = new System.Drawing.Point(4, 22);
            this.ProjectManage_tab.Name = "ProjectManage_tab";
            this.ProjectManage_tab.Padding = new System.Windows.Forms.Padding(3);
            this.ProjectManage_tab.Size = new System.Drawing.Size(415, 202);
            this.ProjectManage_tab.TabIndex = 3;
            this.ProjectManage_tab.Text = "コード発行";
            this.ProjectManage_tab.UseVisualStyleBackColor = true;
            this.ProjectManage_tab.Click += new System.EventHandler(this.コード発行_Click);
            // 
            // MasterManage_tab
            // 
            this.MasterManage_tab.Location = new System.Drawing.Point(4, 22);
            this.MasterManage_tab.Name = "MasterManage_tab";
            this.MasterManage_tab.Padding = new System.Windows.Forms.Padding(3);
            this.MasterManage_tab.Size = new System.Drawing.Size(415, 202);
            this.MasterManage_tab.TabIndex = 4;
            this.MasterManage_tab.Text = "マスタ管理";
            this.MasterManage_tab.UseVisualStyleBackColor = true;
            // 
            // DalyReport_button
            // 
            this.DalyReport_button.Location = new System.Drawing.Point(30, 20);
            this.DalyReport_button.Name = "DalyReport_button";
            this.DalyReport_button.Size = new System.Drawing.Size(100, 40);
            this.DalyReport_button.TabIndex = 0;
            this.DalyReport_button.Text = "勤務日報";
            this.DalyReport_button.UseVisualStyleBackColor = true;
            this.DalyReport_button.Click += new System.EventHandler(this.DalyReport_Click);
            // 
            // ViewWorkRecord_button
            // 
            this.ViewWorkRecord_button.Location = new System.Drawing.Point(30, 20);
            this.ViewWorkRecord_button.Name = "ViewWorkRecord_button";
            this.ViewWorkRecord_button.Size = new System.Drawing.Size(100, 40);
            this.ViewWorkRecord_button.TabIndex = 0;
            this.ViewWorkRecord_button.Text = "勤務一覧表示";
            this.ViewWorkRecord_button.UseVisualStyleBackColor = true;
            // 
            // OutputCSV_button
            // 
            this.OutputCSV_button.Location = new System.Drawing.Point(30, 20);
            this.OutputCSV_button.Name = "OutputCSV_button";
            this.OutputCSV_button.Size = new System.Drawing.Size(100, 40);
            this.OutputCSV_button.TabIndex = 0;
            this.OutputCSV_button.Text = "データ出力";
            this.OutputCSV_button.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 336);
            this.Controls.Add(this.MainFunctionTab);
            this.Name = "MainWindow";
            this.Text = "日報管理メインメニュー";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainFunctionTab.ResumeLayout(false);
            this.Report_tab.ResumeLayout(false);
            this.View_tab.ResumeLayout(false);
            this.Collect_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainFunctionTab;
        private System.Windows.Forms.TabPage Report_tab;
        private System.Windows.Forms.TabPage View_tab;
        private System.Windows.Forms.TabPage Collect_tab;
        private System.Windows.Forms.TabPage ProjectManage_tab;
        private System.Windows.Forms.TabPage MasterManage_tab;
        private System.Windows.Forms.Button DalyReport_button;
        private System.Windows.Forms.Button ViewWorkRecord_button;
        private System.Windows.Forms.Button OutputCSV_button;
    }
}

