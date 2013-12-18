namespace NIPPO
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
            this.DalyReport_button = new System.Windows.Forms.Button();
            this.View_tab = new System.Windows.Forms.TabPage();
            this.ViewWorkRecord_button = new System.Windows.Forms.Button();
            this.Collect_tab = new System.Windows.Forms.TabPage();
            this.OutputCSV_button = new System.Windows.Forms.Button();
            this.ProjectManage_tab = new System.Windows.Forms.TabPage();
            this.MasterManage_tab = new System.Windows.Forms.TabPage();
            this.FY_domainUpDown = new System.Windows.Forms.DomainUpDown();
            this.FY_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.user_label_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.user_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainFunctionTab.SuspendLayout();
            this.Report_tab.SuspendLayout();
            this.View_tab.SuspendLayout();
            this.Collect_tab.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFunctionTab
            // 
            this.MainFunctionTab.Controls.Add(this.Report_tab);
            this.MainFunctionTab.Controls.Add(this.View_tab);
            this.MainFunctionTab.Controls.Add(this.Collect_tab);
            this.MainFunctionTab.Controls.Add(this.ProjectManage_tab);
            this.MainFunctionTab.Controls.Add(this.MasterManage_tab);
            this.MainFunctionTab.Location = new System.Drawing.Point(41, 81);
            this.MainFunctionTab.Margin = new System.Windows.Forms.Padding(4);
            this.MainFunctionTab.Name = "MainFunctionTab";
            this.MainFunctionTab.SelectedIndex = 0;
            this.MainFunctionTab.Size = new System.Drawing.Size(564, 285);
            this.MainFunctionTab.TabIndex = 0;
            // 
            // Report_tab
            // 
            this.Report_tab.Controls.Add(this.DalyReport_button);
            this.Report_tab.Location = new System.Drawing.Point(4, 25);
            this.Report_tab.Margin = new System.Windows.Forms.Padding(4);
            this.Report_tab.Name = "Report_tab";
            this.Report_tab.Padding = new System.Windows.Forms.Padding(4);
            this.Report_tab.Size = new System.Drawing.Size(556, 256);
            this.Report_tab.TabIndex = 0;
            this.Report_tab.Text = "日報入力";
            this.Report_tab.UseVisualStyleBackColor = true;
            // 
            // DalyReport_button
            // 
            this.DalyReport_button.Location = new System.Drawing.Point(40, 25);
            this.DalyReport_button.Margin = new System.Windows.Forms.Padding(4);
            this.DalyReport_button.Name = "DalyReport_button";
            this.DalyReport_button.Size = new System.Drawing.Size(133, 50);
            this.DalyReport_button.TabIndex = 0;
            this.DalyReport_button.Text = "勤務日報";
            this.DalyReport_button.UseVisualStyleBackColor = true;
            this.DalyReport_button.Click += new System.EventHandler(this.DalyReport_Click);
            // 
            // View_tab
            // 
            this.View_tab.Controls.Add(this.ViewWorkRecord_button);
            this.View_tab.Location = new System.Drawing.Point(4, 25);
            this.View_tab.Margin = new System.Windows.Forms.Padding(4);
            this.View_tab.Name = "View_tab";
            this.View_tab.Padding = new System.Windows.Forms.Padding(4);
            this.View_tab.Size = new System.Drawing.Size(556, 256);
            this.View_tab.TabIndex = 1;
            this.View_tab.Text = "一覧表示";
            this.View_tab.UseVisualStyleBackColor = true;
            // 
            // ViewWorkRecord_button
            // 
            this.ViewWorkRecord_button.Location = new System.Drawing.Point(40, 25);
            this.ViewWorkRecord_button.Margin = new System.Windows.Forms.Padding(4);
            this.ViewWorkRecord_button.Name = "ViewWorkRecord_button";
            this.ViewWorkRecord_button.Size = new System.Drawing.Size(133, 50);
            this.ViewWorkRecord_button.TabIndex = 0;
            this.ViewWorkRecord_button.Text = "勤務一覧表示";
            this.ViewWorkRecord_button.UseVisualStyleBackColor = true;
            this.ViewWorkRecord_button.Click += new System.EventHandler(this.ViewWorkRecord_button_Click);
            // 
            // Collect_tab
            // 
            this.Collect_tab.Controls.Add(this.OutputCSV_button);
            this.Collect_tab.Location = new System.Drawing.Point(4, 25);
            this.Collect_tab.Margin = new System.Windows.Forms.Padding(4);
            this.Collect_tab.Name = "Collect_tab";
            this.Collect_tab.Padding = new System.Windows.Forms.Padding(4);
            this.Collect_tab.Size = new System.Drawing.Size(556, 256);
            this.Collect_tab.TabIndex = 2;
            this.Collect_tab.Text = "集計";
            this.Collect_tab.UseVisualStyleBackColor = true;
            // 
            // OutputCSV_button
            // 
            this.OutputCSV_button.Location = new System.Drawing.Point(40, 25);
            this.OutputCSV_button.Margin = new System.Windows.Forms.Padding(4);
            this.OutputCSV_button.Name = "OutputCSV_button";
            this.OutputCSV_button.Size = new System.Drawing.Size(133, 50);
            this.OutputCSV_button.TabIndex = 0;
            this.OutputCSV_button.Text = "データ出力";
            this.OutputCSV_button.UseVisualStyleBackColor = true;
            // 
            // ProjectManage_tab
            // 
            this.ProjectManage_tab.Location = new System.Drawing.Point(4, 25);
            this.ProjectManage_tab.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectManage_tab.Name = "ProjectManage_tab";
            this.ProjectManage_tab.Padding = new System.Windows.Forms.Padding(4);
            this.ProjectManage_tab.Size = new System.Drawing.Size(556, 256);
            this.ProjectManage_tab.TabIndex = 3;
            this.ProjectManage_tab.Text = "コード発行";
            this.ProjectManage_tab.UseVisualStyleBackColor = true;
            this.ProjectManage_tab.Click += new System.EventHandler(this.コード発行_Click);
            // 
            // MasterManage_tab
            // 
            this.MasterManage_tab.Location = new System.Drawing.Point(4, 25);
            this.MasterManage_tab.Margin = new System.Windows.Forms.Padding(4);
            this.MasterManage_tab.Name = "MasterManage_tab";
            this.MasterManage_tab.Padding = new System.Windows.Forms.Padding(4);
            this.MasterManage_tab.Size = new System.Drawing.Size(556, 256);
            this.MasterManage_tab.TabIndex = 4;
            this.MasterManage_tab.Text = "マスタ管理";
            this.MasterManage_tab.UseVisualStyleBackColor = true;
            // 
            // FY_domainUpDown
            // 
            this.FY_domainUpDown.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.FY_domainUpDown.Location = new System.Drawing.Point(41, 34);
            this.FY_domainUpDown.Name = "FY_domainUpDown";
            this.FY_domainUpDown.ReadOnly = true;
            this.FY_domainUpDown.Size = new System.Drawing.Size(82, 27);
            this.FY_domainUpDown.TabIndex = 1;
            this.FY_domainUpDown.Text = "2013";
            this.FY_domainUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FY_label
            // 
            this.FY_label.AutoSize = true;
            this.FY_label.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.FY_label.Location = new System.Drawing.Point(129, 38);
            this.FY_label.Name = "FY_label";
            this.FY_label.Size = new System.Drawing.Size(49, 20);
            this.FY_label.TabIndex = 2;
            this.FY_label.Text = "年度";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(526, 38);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "終了";
            this.exit_button.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.user_label_toolStripStatusLabel,
            this.user_toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 396);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(647, 24);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // user_label_toolStripStatusLabel
            // 
            this.user_label_toolStripStatusLabel.Name = "user_label_toolStripStatusLabel";
            this.user_label_toolStripStatusLabel.Size = new System.Drawing.Size(102, 19);
            this.user_label_toolStripStatusLabel.Text = "Login User : ";
            // 
            // user_toolStripStatusLabel
            // 
            this.user_toolStripStatusLabel.Name = "user_toolStripStatusLabel";
            this.user_toolStripStatusLabel.Size = new System.Drawing.Size(23, 19);
            this.user_toolStripStatusLabel.Text = "--";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 420);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.FY_label);
            this.Controls.Add(this.FY_domainUpDown);
            this.Controls.Add(this.MainFunctionTab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "日報管理メインメニュー";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainFunctionTab.ResumeLayout(false);
            this.Report_tab.ResumeLayout(false);
            this.View_tab.ResumeLayout(false);
            this.Collect_tab.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DomainUpDown FY_domainUpDown;
        private System.Windows.Forms.Label FY_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel user_label_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel user_toolStripStatusLabel;
    }
}

