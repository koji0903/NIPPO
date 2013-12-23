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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FYMonth_label = new System.Windows.Forms.Label();
            this.nextMonth_button = new System.Windows.Forms.Button();
            this.prevMonth_button = new System.Windows.Forms.Button();
            this.list_dataGridView = new System.Windows.Forms.DataGridView();
            this.day_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.week_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_times_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overtime125_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overtime150_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holiday_work_times_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.editable_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.user_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.statusStrip1.SuspendLayout();
            this.summary_groupBox.SuspendLayout();
            this.collection_tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // FYMonth_label
            // 
            this.FYMonth_label.AutoSize = true;
            this.FYMonth_label.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.FYMonth_label.Location = new System.Drawing.Point(262, 10);
            this.FYMonth_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FYMonth_label.Name = "FYMonth_label";
            this.FYMonth_label.Size = new System.Drawing.Size(138, 22);
            this.FYMonth_label.TabIndex = 0;
            this.FYMonth_label.Text = "YYYY年MM月";
            // 
            // nextMonth_button
            // 
            this.nextMonth_button.Location = new System.Drawing.Point(422, 10);
            this.nextMonth_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextMonth_button.Name = "nextMonth_button";
            this.nextMonth_button.Size = new System.Drawing.Size(22, 18);
            this.nextMonth_button.TabIndex = 1;
            this.nextMonth_button.Text = ">";
            this.nextMonth_button.UseVisualStyleBackColor = true;
            this.nextMonth_button.Click += new System.EventHandler(this.nextMonth_button_Click);
            // 
            // prevMonth_button
            // 
            this.prevMonth_button.Location = new System.Drawing.Point(206, 10);
            this.prevMonth_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prevMonth_button.Name = "prevMonth_button";
            this.prevMonth_button.Size = new System.Drawing.Size(22, 18);
            this.prevMonth_button.TabIndex = 1;
            this.prevMonth_button.Text = "<";
            this.prevMonth_button.UseVisualStyleBackColor = true;
            this.prevMonth_button.Click += new System.EventHandler(this.prevMonth_button_Click);
            // 
            // list_dataGridView
            // 
            this.list_dataGridView.AllowUserToAddRows = false;
            this.list_dataGridView.AllowUserToDeleteRows = false;
            this.list_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.day_TextBox,
            this.ID_TextBox,
            this.week_TextBox,
            this.start_time_TextBox,
            this.end_time_TextBox,
            this.work_times_TextBox,
            this.overtime125_TextBox,
            this.overtime150_TextBox,
            this.holiday_work_times_TextBox,
            this.note_TextBox});
            this.list_dataGridView.Location = new System.Drawing.Point(26, 41);
            this.list_dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_dataGridView.MultiSelect = false;
            this.list_dataGridView.Name = "list_dataGridView";
            this.list_dataGridView.ReadOnly = true;
            this.list_dataGridView.RowHeadersVisible = false;
            this.list_dataGridView.RowTemplate.Height = 16;
            this.list_dataGridView.RowTemplate.ReadOnly = true;
            this.list_dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.list_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_dataGridView.Size = new System.Drawing.Size(621, 455);
            this.list_dataGridView.TabIndex = 2;
            this.list_dataGridView.DoubleClick += new System.EventHandler(this.list_dataGridView_DoubleClick);
            // 
            // day_TextBox
            // 
            this.day_TextBox.DataPropertyName = "day";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.day_TextBox.DefaultCellStyle = dataGridViewCellStyle1;
            this.day_TextBox.HeaderText = "日";
            this.day_TextBox.Name = "day_TextBox";
            this.day_TextBox.ReadOnly = true;
            this.day_TextBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.day_TextBox.Width = 25;
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.DataPropertyName = "ID";
            this.ID_TextBox.HeaderText = "ID";
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.ReadOnly = true;
            this.ID_TextBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_TextBox.Visible = false;
            // 
            // week_TextBox
            // 
            this.week_TextBox.DataPropertyName = "week";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.week_TextBox.DefaultCellStyle = dataGridViewCellStyle2;
            this.week_TextBox.HeaderText = "曜日";
            this.week_TextBox.Name = "week_TextBox";
            this.week_TextBox.ReadOnly = true;
            this.week_TextBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.week_TextBox.Width = 25;
            // 
            // start_time_TextBox
            // 
            this.start_time_TextBox.DataPropertyName = "start_time";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.start_time_TextBox.DefaultCellStyle = dataGridViewCellStyle3;
            this.start_time_TextBox.HeaderText = "勤務開始時刻";
            this.start_time_TextBox.Name = "start_time_TextBox";
            this.start_time_TextBox.ReadOnly = true;
            this.start_time_TextBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.start_time_TextBox.Width = 75;
            // 
            // end_time_TextBox
            // 
            this.end_time_TextBox.DataPropertyName = "end_time";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.end_time_TextBox.DefaultCellStyle = dataGridViewCellStyle4;
            this.end_time_TextBox.HeaderText = "勤務終了時刻";
            this.end_time_TextBox.Name = "end_time_TextBox";
            this.end_time_TextBox.ReadOnly = true;
            this.end_time_TextBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.end_time_TextBox.Width = 75;
            // 
            // work_times_TextBox
            // 
            this.work_times_TextBox.DataPropertyName = "work_times";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.work_times_TextBox.DefaultCellStyle = dataGridViewCellStyle5;
            this.work_times_TextBox.HeaderText = "勤務時間";
            this.work_times_TextBox.Name = "work_times_TextBox";
            this.work_times_TextBox.ReadOnly = true;
            this.work_times_TextBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.work_times_TextBox.Width = 75;
            // 
            // overtime125_TextBox
            // 
            this.overtime125_TextBox.DataPropertyName = "overtime125";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.overtime125_TextBox.DefaultCellStyle = dataGridViewCellStyle6;
            this.overtime125_TextBox.HeaderText = "普通残業時間";
            this.overtime125_TextBox.Name = "overtime125_TextBox";
            this.overtime125_TextBox.ReadOnly = true;
            this.overtime125_TextBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.overtime125_TextBox.Width = 75;
            // 
            // overtime150_TextBox
            // 
            this.overtime150_TextBox.DataPropertyName = "overtime150";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.overtime150_TextBox.DefaultCellStyle = dataGridViewCellStyle7;
            this.overtime150_TextBox.HeaderText = "深夜残業時間";
            this.overtime150_TextBox.Name = "overtime150_TextBox";
            this.overtime150_TextBox.ReadOnly = true;
            this.overtime150_TextBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.overtime150_TextBox.Width = 75;
            // 
            // holiday_work_times_TextBox
            // 
            this.holiday_work_times_TextBox.DataPropertyName = "holiday_work_times";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.holiday_work_times_TextBox.DefaultCellStyle = dataGridViewCellStyle8;
            this.holiday_work_times_TextBox.HeaderText = "休日出勤";
            this.holiday_work_times_TextBox.Name = "holiday_work_times_TextBox";
            this.holiday_work_times_TextBox.ReadOnly = true;
            this.holiday_work_times_TextBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.holiday_work_times_TextBox.Width = 75;
            // 
            // note_TextBox
            // 
            this.note_TextBox.DataPropertyName = "note";
            this.note_TextBox.HeaderText = "備考";
            this.note_TextBox.Name = "note_TextBox";
            this.note_TextBox.ReadOnly = true;
            this.note_TextBox.Width = 250;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editable_toolStripStatusLabel,
            this.user_toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(971, 23);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // editable_toolStripStatusLabel
            // 
            this.editable_toolStripStatusLabel.Name = "editable_toolStripStatusLabel";
            this.editable_toolStripStatusLabel.Size = new System.Drawing.Size(44, 18);
            this.editable_toolStripStatusLabel.Text = "編集可";
            // 
            // user_toolStripStatusLabel
            // 
            this.user_toolStripStatusLabel.Name = "user_toolStripStatusLabel";
            this.user_toolStripStatusLabel.Size = new System.Drawing.Size(116, 18);
            this.user_toolStripStatusLabel.Text = "表示対象のユーザ名";
            // 
            // summary_groupBox
            // 
            this.summary_groupBox.Controls.Add(this.totalOverTime150_textBox);
            this.summary_groupBox.Controls.Add(this.totalOverTime125_textBox);
            this.summary_groupBox.Controls.Add(this.totalTime_textBox);
            this.summary_groupBox.Controls.Add(this.totalOverTime150_label);
            this.summary_groupBox.Controls.Add(this.totalOverTime125_label);
            this.summary_groupBox.Controls.Add(this.totalTime_label);
            this.summary_groupBox.Location = new System.Drawing.Point(666, 26);
            this.summary_groupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.summary_groupBox.Name = "summary_groupBox";
            this.summary_groupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.summary_groupBox.Size = new System.Drawing.Size(190, 112);
            this.summary_groupBox.TabIndex = 4;
            this.summary_groupBox.TabStop = false;
            this.summary_groupBox.Text = "集計";
            // 
            // totalOverTime150_textBox
            // 
            this.totalOverTime150_textBox.Location = new System.Drawing.Point(97, 82);
            this.totalOverTime150_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalOverTime150_textBox.Name = "totalOverTime150_textBox";
            this.totalOverTime150_textBox.ReadOnly = true;
            this.totalOverTime150_textBox.Size = new System.Drawing.Size(76, 19);
            this.totalOverTime150_textBox.TabIndex = 1;
            this.totalOverTime150_textBox.Text = "h";
            this.totalOverTime150_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalOverTime125_textBox
            // 
            this.totalOverTime125_textBox.Location = new System.Drawing.Point(97, 54);
            this.totalOverTime125_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalOverTime125_textBox.Name = "totalOverTime125_textBox";
            this.totalOverTime125_textBox.ReadOnly = true;
            this.totalOverTime125_textBox.Size = new System.Drawing.Size(76, 19);
            this.totalOverTime125_textBox.TabIndex = 1;
            this.totalOverTime125_textBox.Text = "h";
            this.totalOverTime125_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalTime_textBox
            // 
            this.totalTime_textBox.Location = new System.Drawing.Point(97, 29);
            this.totalTime_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalTime_textBox.Name = "totalTime_textBox";
            this.totalTime_textBox.ReadOnly = true;
            this.totalTime_textBox.Size = new System.Drawing.Size(76, 19);
            this.totalTime_textBox.TabIndex = 1;
            this.totalTime_textBox.Text = "h";
            this.totalTime_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalOverTime150_label
            // 
            this.totalOverTime150_label.AutoSize = true;
            this.totalOverTime150_label.Location = new System.Drawing.Point(13, 84);
            this.totalOverTime150_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalOverTime150_label.Name = "totalOverTime150_label";
            this.totalOverTime150_label.Size = new System.Drawing.Size(77, 12);
            this.totalOverTime150_label.TabIndex = 0;
            this.totalOverTime150_label.Text = "深夜勤務時間";
            this.totalOverTime150_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalOverTime125_label
            // 
            this.totalOverTime125_label.AutoSize = true;
            this.totalOverTime125_label.Location = new System.Drawing.Point(13, 56);
            this.totalOverTime125_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalOverTime125_label.Name = "totalOverTime125_label";
            this.totalOverTime125_label.Size = new System.Drawing.Size(77, 12);
            this.totalOverTime125_label.TabIndex = 0;
            this.totalOverTime125_label.Text = "超過勤務時間";
            this.totalOverTime125_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalTime_label
            // 
            this.totalTime_label.AutoSize = true;
            this.totalTime_label.Location = new System.Drawing.Point(35, 31);
            this.totalTime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalTime_label.Name = "totalTime_label";
            this.totalTime_label.Size = new System.Drawing.Size(53, 12);
            this.totalTime_label.TabIndex = 0;
            this.totalTime_label.Text = "勤務時間";
            this.totalTime_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // collection_tabControl
            // 
            this.collection_tabControl.Controls.Add(this.project_tabPage);
            this.collection_tabControl.Controls.Add(this.work_tabPage);
            this.collection_tabControl.Location = new System.Drawing.Point(666, 160);
            this.collection_tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.collection_tabControl.Name = "collection_tabControl";
            this.collection_tabControl.SelectedIndex = 0;
            this.collection_tabControl.Size = new System.Drawing.Size(290, 137);
            this.collection_tabControl.TabIndex = 5;
            // 
            // project_tabPage
            // 
            this.project_tabPage.Location = new System.Drawing.Point(4, 22);
            this.project_tabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.project_tabPage.Name = "project_tabPage";
            this.project_tabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.project_tabPage.Size = new System.Drawing.Size(282, 111);
            this.project_tabPage.TabIndex = 0;
            this.project_tabPage.Text = "プロジェクト別集計";
            this.project_tabPage.UseVisualStyleBackColor = true;
            // 
            // work_tabPage
            // 
            this.work_tabPage.Location = new System.Drawing.Point(4, 22);
            this.work_tabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.work_tabPage.Name = "work_tabPage";
            this.work_tabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.work_tabPage.Size = new System.Drawing.Size(282, 111);
            this.work_tabPage.TabIndex = 1;
            this.work_tabPage.Text = "業務別集計";
            this.work_tabPage.UseVisualStyleBackColor = true;
            // 
            // dailyWork_groupBox
            // 
            this.dailyWork_groupBox.Location = new System.Drawing.Point(669, 319);
            this.dailyWork_groupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dailyWork_groupBox.Name = "dailyWork_groupBox";
            this.dailyWork_groupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dailyWork_groupBox.Size = new System.Drawing.Size(283, 152);
            this.dailyWork_groupBox.TabIndex = 6;
            this.dailyWork_groupBox.TabStop = false;
            this.dailyWork_groupBox.Text = "1日の業務一覧";
            // 
            // outputExcel_button
            // 
            this.outputExcel_button.Location = new System.Drawing.Point(26, 501);
            this.outputExcel_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputExcel_button.Name = "outputExcel_button";
            this.outputExcel_button.Size = new System.Drawing.Size(76, 26);
            this.outputExcel_button.TabIndex = 7;
            this.outputExcel_button.Text = "Excel出力";
            this.outputExcel_button.UseVisualStyleBackColor = true;
            this.outputExcel_button.Click += new System.EventHandler(this.outputExcel_button_Click);
            // 
            // closeWindow_button
            // 
            this.closeWindow_button.Location = new System.Drawing.Point(880, 504);
            this.closeWindow_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeWindow_button.Name = "closeWindow_button";
            this.closeWindow_button.Size = new System.Drawing.Size(76, 22);
            this.closeWindow_button.TabIndex = 7;
            this.closeWindow_button.Text = "閉じる";
            this.closeWindow_button.UseVisualStyleBackColor = true;
            this.closeWindow_button.Click += new System.EventHandler(this.closeWindow_button_Click);
            // 
            // MonthlyReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 550);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MonthlyReportWindow";
            this.Text = "MonthlyReportWindow";
            this.Shown += new System.EventHandler(this.Me_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.list_dataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripStatusLabel editable_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel user_toolStripStatusLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn day_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn week_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_time_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_times_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn overtime125_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn overtime150_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn holiday_work_times_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn note_TextBox;
    }
}