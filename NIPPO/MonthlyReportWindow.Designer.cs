namespace NIPPO
{
    partial class MonthlyReportWindow
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
            this.FYMonth_label = new System.Windows.Forms.Label();
            this.nextMonth_button = new System.Windows.Forms.Button();
            this.prevMonth_button = new System.Windows.Forms.Button();
            this.list_dataGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.summary_groupBox = new System.Windows.Forms.GroupBox();
            this.totalOverTime150_textBox = new System.Windows.Forms.TextBox();
            this.totalOverTime125_textBox = new System.Windows.Forms.TextBox();
            this.totalTime_textBox = new System.Windows.Forms.TextBox();
            this.totalOverTime150_label = new System.Windows.Forms.Label();
            this.totalOverTime125_label = new System.Windows.Forms.Label();
            this.totalTime_label = new System.Windows.Forms.Label();
            this.collection_tabControl = new System.Windows.Forms.TabControl();
            this.project_tabPage = new System.Windows.Forms.TabPage();
            this.work_tabPage = new System.Windows.Forms.TabPage();
            this.dailyWork_groupBox = new System.Windows.Forms.GroupBox();
            this.outputExcel_button = new System.Windows.Forms.Button();
            this.closeWindow_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_dataGridView)).BeginInit();
            this.summary_groupBox.SuspendLayout();
            this.collection_tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // FYMonth_label
            // 
            this.FYMonth_label.AutoSize = true;
            this.FYMonth_label.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.FYMonth_label.Location = new System.Drawing.Point(228, 22);
            this.FYMonth_label.Name = "FYMonth_label";
            this.FYMonth_label.Size = new System.Drawing.Size(170, 27);
            this.FYMonth_label.TabIndex = 0;
            this.FYMonth_label.Text = "YYYY年MM月";
            // 
            // nextMonth_button
            // 
            this.nextMonth_button.Location = new System.Drawing.Point(441, 22);
            this.nextMonth_button.Name = "nextMonth_button";
            this.nextMonth_button.Size = new System.Drawing.Size(29, 23);
            this.nextMonth_button.TabIndex = 1;
            this.nextMonth_button.Text = ">";
            this.nextMonth_button.UseVisualStyleBackColor = true;
            this.nextMonth_button.Click += new System.EventHandler(this.nextMonth_button_Click);
            // 
            // prevMonth_button
            // 
            this.prevMonth_button.Location = new System.Drawing.Point(152, 22);
            this.prevMonth_button.Name = "prevMonth_button";
            this.prevMonth_button.Size = new System.Drawing.Size(29, 23);
            this.prevMonth_button.TabIndex = 1;
            this.prevMonth_button.Text = "<";
            this.prevMonth_button.UseVisualStyleBackColor = true;
            // 
            // list_dataGridView
            // 
            this.list_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_dataGridView.Location = new System.Drawing.Point(35, 66);
            this.list_dataGridView.Name = "list_dataGridView";
            this.list_dataGridView.RowTemplate.Height = 24;
            this.list_dataGridView.Size = new System.Drawing.Size(560, 523);
            this.list_dataGridView.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 630);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1011, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // summary_groupBox
            // 
            this.summary_groupBox.Controls.Add(this.totalOverTime150_textBox);
            this.summary_groupBox.Controls.Add(this.totalOverTime125_textBox);
            this.summary_groupBox.Controls.Add(this.totalTime_textBox);
            this.summary_groupBox.Controls.Add(this.totalOverTime150_label);
            this.summary_groupBox.Controls.Add(this.totalOverTime125_label);
            this.summary_groupBox.Controls.Add(this.totalTime_label);
            this.summary_groupBox.Location = new System.Drawing.Point(613, 33);
            this.summary_groupBox.Name = "summary_groupBox";
            this.summary_groupBox.Size = new System.Drawing.Size(254, 140);
            this.summary_groupBox.TabIndex = 4;
            this.summary_groupBox.TabStop = false;
            this.summary_groupBox.Text = "集計";
            // 
            // totalOverTime150_textBox
            // 
            this.totalOverTime150_textBox.Location = new System.Drawing.Point(129, 102);
            this.totalOverTime150_textBox.Name = "totalOverTime150_textBox";
            this.totalOverTime150_textBox.ReadOnly = true;
            this.totalOverTime150_textBox.Size = new System.Drawing.Size(100, 22);
            this.totalOverTime150_textBox.TabIndex = 1;
            this.totalOverTime150_textBox.Text = "h";
            this.totalOverTime150_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalOverTime125_textBox
            // 
            this.totalOverTime125_textBox.Location = new System.Drawing.Point(129, 67);
            this.totalOverTime125_textBox.Name = "totalOverTime125_textBox";
            this.totalOverTime125_textBox.ReadOnly = true;
            this.totalOverTime125_textBox.Size = new System.Drawing.Size(100, 22);
            this.totalOverTime125_textBox.TabIndex = 1;
            this.totalOverTime125_textBox.Text = "h";
            this.totalOverTime125_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalTime_textBox
            // 
            this.totalTime_textBox.Location = new System.Drawing.Point(129, 36);
            this.totalTime_textBox.Name = "totalTime_textBox";
            this.totalTime_textBox.ReadOnly = true;
            this.totalTime_textBox.Size = new System.Drawing.Size(100, 22);
            this.totalTime_textBox.TabIndex = 1;
            this.totalTime_textBox.Text = "h";
            this.totalTime_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalOverTime150_label
            // 
            this.totalOverTime150_label.AutoSize = true;
            this.totalOverTime150_label.Location = new System.Drawing.Point(17, 105);
            this.totalOverTime150_label.Name = "totalOverTime150_label";
            this.totalOverTime150_label.Size = new System.Drawing.Size(97, 15);
            this.totalOverTime150_label.TabIndex = 0;
            this.totalOverTime150_label.Text = "深夜勤務時間";
            this.totalOverTime150_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalOverTime125_label
            // 
            this.totalOverTime125_label.AutoSize = true;
            this.totalOverTime125_label.Location = new System.Drawing.Point(17, 70);
            this.totalOverTime125_label.Name = "totalOverTime125_label";
            this.totalOverTime125_label.Size = new System.Drawing.Size(97, 15);
            this.totalOverTime125_label.TabIndex = 0;
            this.totalOverTime125_label.Text = "超過勤務時間";
            this.totalOverTime125_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalTime_label
            // 
            this.totalTime_label.AutoSize = true;
            this.totalTime_label.Location = new System.Drawing.Point(47, 39);
            this.totalTime_label.Name = "totalTime_label";
            this.totalTime_label.Size = new System.Drawing.Size(67, 15);
            this.totalTime_label.TabIndex = 0;
            this.totalTime_label.Text = "勤務時間";
            this.totalTime_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // collection_tabControl
            // 
            this.collection_tabControl.Controls.Add(this.project_tabPage);
            this.collection_tabControl.Controls.Add(this.work_tabPage);
            this.collection_tabControl.Location = new System.Drawing.Point(613, 200);
            this.collection_tabControl.Name = "collection_tabControl";
            this.collection_tabControl.SelectedIndex = 0;
            this.collection_tabControl.Size = new System.Drawing.Size(386, 171);
            this.collection_tabControl.TabIndex = 5;
            // 
            // project_tabPage
            // 
            this.project_tabPage.Location = new System.Drawing.Point(4, 25);
            this.project_tabPage.Name = "project_tabPage";
            this.project_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.project_tabPage.Size = new System.Drawing.Size(378, 142);
            this.project_tabPage.TabIndex = 0;
            this.project_tabPage.Text = "プロジェクト別集計";
            this.project_tabPage.UseVisualStyleBackColor = true;
            // 
            // work_tabPage
            // 
            this.work_tabPage.Location = new System.Drawing.Point(4, 25);
            this.work_tabPage.Name = "work_tabPage";
            this.work_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.work_tabPage.Size = new System.Drawing.Size(378, 142);
            this.work_tabPage.TabIndex = 1;
            this.work_tabPage.Text = "業務別集計";
            this.work_tabPage.UseVisualStyleBackColor = true;
            // 
            // dailyWork_groupBox
            // 
            this.dailyWork_groupBox.Location = new System.Drawing.Point(617, 399);
            this.dailyWork_groupBox.Name = "dailyWork_groupBox";
            this.dailyWork_groupBox.Size = new System.Drawing.Size(377, 190);
            this.dailyWork_groupBox.TabIndex = 6;
            this.dailyWork_groupBox.TabStop = false;
            this.dailyWork_groupBox.Text = "1日の業務一覧";
            // 
            // outputExcel_button
            // 
            this.outputExcel_button.Location = new System.Drawing.Point(35, 598);
            this.outputExcel_button.Name = "outputExcel_button";
            this.outputExcel_button.Size = new System.Drawing.Size(101, 23);
            this.outputExcel_button.TabIndex = 7;
            this.outputExcel_button.Text = "Excel出力";
            this.outputExcel_button.UseVisualStyleBackColor = true;
            // 
            // closeWindow_button
            // 
            this.closeWindow_button.Location = new System.Drawing.Point(898, 598);
            this.closeWindow_button.Name = "closeWindow_button";
            this.closeWindow_button.Size = new System.Drawing.Size(101, 23);
            this.closeWindow_button.TabIndex = 7;
            this.closeWindow_button.Text = "閉じる";
            this.closeWindow_button.UseVisualStyleBackColor = true;
            this.closeWindow_button.Click += new System.EventHandler(this.closeWindow_button_Click);
            // 
            // MonthlyReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 652);
            this.Controls.Add(this.closeWindow_button);
            this.Controls.Add(this.outputExcel_button);
            this.Controls.Add(this.dailyWork_groupBox);
            this.Controls.Add(this.collection_tabControl);
            this.Controls.Add(this.summary_groupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.list_dataGridView);
            this.Controls.Add(this.prevMonth_button);
            this.Controls.Add(this.nextMonth_button);
            this.Controls.Add(this.FYMonth_label);
            this.Name = "MonthlyReportWindow";
            this.Text = "MonthlyReportWindow";
            ((System.ComponentModel.ISupportInitialize)(this.list_dataGridView)).EndInit();
            this.summary_groupBox.ResumeLayout(false);
            this.summary_groupBox.PerformLayout();
            this.collection_tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FYMonth_label;
        private System.Windows.Forms.Button nextMonth_button;
        private System.Windows.Forms.Button prevMonth_button;
        private System.Windows.Forms.DataGridView list_dataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox summary_groupBox;
        private System.Windows.Forms.TextBox totalOverTime150_textBox;
        private System.Windows.Forms.TextBox totalOverTime125_textBox;
        private System.Windows.Forms.TextBox totalTime_textBox;
        private System.Windows.Forms.Label totalOverTime150_label;
        private System.Windows.Forms.Label totalOverTime125_label;
        private System.Windows.Forms.Label totalTime_label;
        private System.Windows.Forms.TabControl collection_tabControl;
        private System.Windows.Forms.TabPage project_tabPage;
        private System.Windows.Forms.TabPage work_tabPage;
        private System.Windows.Forms.GroupBox dailyWork_groupBox;
        private System.Windows.Forms.Button outputExcel_button;
        private System.Windows.Forms.Button closeWindow_button;
    }
}