namespace NIPPO
{
    partial class DailyReportWindow
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
            this.WorkDetail_DateGridView = new System.Windows.Forms.DataGridView();
            this.Calender_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NightOverTime_Textbox = new System.Windows.Forms.TextBox();
            this.NormalOverTime_Textbox = new System.Windows.Forms.TextBox();
            this.RestTime_Textbox = new System.Windows.Forms.TextBox();
            this.WorkTime_Textbox = new System.Windows.Forms.TextBox();
            this.NightOverTime_Label = new System.Windows.Forms.Label();
            this.RestTime_Label = new System.Windows.Forms.Label();
            this.NormalOverTime_Label = new System.Windows.Forms.Label();
            this.WorkTime_Label = new System.Windows.Forms.Label();
            this.EndTime_Second_Label = new System.Windows.Forms.Label();
            this.EndTime_Hour_Label = new System.Windows.Forms.Label();
            this.StartTime_Second_Label = new System.Windows.Forms.Label();
            this.StartTime_Hour_Label = new System.Windows.Forms.Label();
            this.EndTime_Label = new System.Windows.Forms.Label();
            this.StartTime_Label = new System.Windows.Forms.Label();
            this.EndTime_Second_Combobox = new System.Windows.Forms.ComboBox();
            this.EndTime_Hour_Combobox = new System.Windows.Forms.ComboBox();
            this.StartTime_Second_Combobox = new System.Windows.Forms.ComboBox();
            this.StartTime_Hour_Combobox = new System.Windows.Forms.ComboBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.TotalWorkTime_Label = new System.Windows.Forms.Label();
            this.TotalWorkTime_Textbox = new System.Windows.Forms.TextBox();
            this.workDetail_groupBox = new System.Windows.Forms.GroupBox();
            this.Description_Textbox = new System.Windows.Forms.TextBox();
            this.Description_Label = new System.Windows.Forms.Label();
            this.WokTime_DomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.SearchBusiness_Button = new System.Windows.Forms.Button();
            this.SerarchProject_Button = new System.Windows.Forms.Button();
            this.TaskName_TextBox = new System.Windows.Forms.TextBox();
            this.TaskCode_Textbox = new System.Windows.Forms.TextBox();
            this.ProjectName_Textbox = new System.Windows.Forms.TextBox();
            this.ProjectCode_Textbox = new System.Windows.Forms.TextBox();
            this.Time_Label = new System.Windows.Forms.Label();
            this.Task_Label = new System.Windows.Forms.Label();
            this.Project_Label = new System.Windows.Forms.Label();
            this.Remark_Label = new System.Windows.Forms.Label();
            this.Remark_Textbox = new System.Windows.Forms.TextBox();
            this.Regist_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.ID_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectID_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskID_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.WorkDetail_DateGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.workDetail_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkDetail_DateGridView
            // 
            this.WorkDetail_DateGridView.AllowUserToAddRows = false;
            this.WorkDetail_DateGridView.AllowUserToDeleteRows = false;
            this.WorkDetail_DateGridView.AllowUserToOrderColumns = true;
            this.WorkDetail_DateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkDetail_DateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TextBox,
            this.name,
            this.task_TextBox,
            this.note_TextBox,
            this.time_TextBox,
            this.projectID_TextBox,
            this.taskID_TextBox});
            this.WorkDetail_DateGridView.Location = new System.Drawing.Point(34, 146);
            this.WorkDetail_DateGridView.Name = "WorkDetail_DateGridView";
            this.WorkDetail_DateGridView.ReadOnly = true;
            this.WorkDetail_DateGridView.RowHeadersVisible = false;
            this.WorkDetail_DateGridView.RowTemplate.Height = 21;
            this.WorkDetail_DateGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WorkDetail_DateGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WorkDetail_DateGridView.Size = new System.Drawing.Size(780, 127);
            this.WorkDetail_DateGridView.TabIndex = 0;
            this.WorkDetail_DateGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WorkDetail_DateGridView_CellContentClick);
            // 
            // Calender_Label
            // 
            this.Calender_Label.AutoSize = true;
            this.Calender_Label.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Calender_Label.Location = new System.Drawing.Point(286, 9);
            this.Calender_Label.Name = "Calender_Label";
            this.Calender_Label.Size = new System.Drawing.Size(341, 33);
            this.Calender_Label.TabIndex = 1;
            this.Calender_Label.Text = "YYYY年MM月DD日（曜）";
            this.Calender_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NightOverTime_Textbox);
            this.panel1.Controls.Add(this.NormalOverTime_Textbox);
            this.panel1.Controls.Add(this.RestTime_Textbox);
            this.panel1.Controls.Add(this.WorkTime_Textbox);
            this.panel1.Controls.Add(this.NightOverTime_Label);
            this.panel1.Controls.Add(this.RestTime_Label);
            this.panel1.Controls.Add(this.NormalOverTime_Label);
            this.panel1.Controls.Add(this.WorkTime_Label);
            this.panel1.Controls.Add(this.EndTime_Second_Label);
            this.panel1.Controls.Add(this.EndTime_Hour_Label);
            this.panel1.Controls.Add(this.StartTime_Second_Label);
            this.panel1.Controls.Add(this.StartTime_Hour_Label);
            this.panel1.Controls.Add(this.EndTime_Label);
            this.panel1.Controls.Add(this.StartTime_Label);
            this.panel1.Controls.Add(this.EndTime_Second_Combobox);
            this.panel1.Controls.Add(this.EndTime_Hour_Combobox);
            this.panel1.Controls.Add(this.StartTime_Second_Combobox);
            this.panel1.Controls.Add(this.StartTime_Hour_Combobox);
            this.panel1.Location = new System.Drawing.Point(34, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 71);
            this.panel1.TabIndex = 4;
            // 
            // NightOverTime_Textbox
            // 
            this.NightOverTime_Textbox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NightOverTime_Textbox.Location = new System.Drawing.Point(635, 37);
            this.NightOverTime_Textbox.Name = "NightOverTime_Textbox";
            this.NightOverTime_Textbox.ReadOnly = true;
            this.NightOverTime_Textbox.Size = new System.Drawing.Size(100, 23);
            this.NightOverTime_Textbox.TabIndex = 16;
            this.NightOverTime_Textbox.Text = "0.00h";
            this.NightOverTime_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NormalOverTime_Textbox
            // 
            this.NormalOverTime_Textbox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NormalOverTime_Textbox.Location = new System.Drawing.Point(635, 12);
            this.NormalOverTime_Textbox.Name = "NormalOverTime_Textbox";
            this.NormalOverTime_Textbox.ReadOnly = true;
            this.NormalOverTime_Textbox.Size = new System.Drawing.Size(100, 23);
            this.NormalOverTime_Textbox.TabIndex = 15;
            this.NormalOverTime_Textbox.Text = "0.00h";
            this.NormalOverTime_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RestTime_Textbox
            // 
            this.RestTime_Textbox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RestTime_Textbox.Location = new System.Drawing.Point(412, 37);
            this.RestTime_Textbox.Name = "RestTime_Textbox";
            this.RestTime_Textbox.ReadOnly = true;
            this.RestTime_Textbox.Size = new System.Drawing.Size(100, 23);
            this.RestTime_Textbox.TabIndex = 15;
            this.RestTime_Textbox.Text = "1.00h";
            this.RestTime_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WorkTime_Textbox
            // 
            this.WorkTime_Textbox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WorkTime_Textbox.Location = new System.Drawing.Point(412, 12);
            this.WorkTime_Textbox.Name = "WorkTime_Textbox";
            this.WorkTime_Textbox.ReadOnly = true;
            this.WorkTime_Textbox.Size = new System.Drawing.Size(100, 23);
            this.WorkTime_Textbox.TabIndex = 14;
            this.WorkTime_Textbox.Text = "7.75h";
            this.WorkTime_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NightOverTime_Label
            // 
            this.NightOverTime_Label.AutoSize = true;
            this.NightOverTime_Label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NightOverTime_Label.Location = new System.Drawing.Point(525, 40);
            this.NightOverTime_Label.Name = "NightOverTime_Label";
            this.NightOverTime_Label.Size = new System.Drawing.Size(104, 16);
            this.NightOverTime_Label.TabIndex = 13;
            this.NightOverTime_Label.Text = "深夜残業時間";
            // 
            // RestTime_Label
            // 
            this.RestTime_Label.AutoSize = true;
            this.RestTime_Label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RestTime_Label.Location = new System.Drawing.Point(334, 40);
            this.RestTime_Label.Name = "RestTime_Label";
            this.RestTime_Label.Size = new System.Drawing.Size(72, 16);
            this.RestTime_Label.TabIndex = 12;
            this.RestTime_Label.Text = "休憩時間";
            // 
            // NormalOverTime_Label
            // 
            this.NormalOverTime_Label.AutoSize = true;
            this.NormalOverTime_Label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NormalOverTime_Label.Location = new System.Drawing.Point(525, 15);
            this.NormalOverTime_Label.Name = "NormalOverTime_Label";
            this.NormalOverTime_Label.Size = new System.Drawing.Size(104, 16);
            this.NormalOverTime_Label.TabIndex = 11;
            this.NormalOverTime_Label.Text = "普通残業時間";
            // 
            // WorkTime_Label
            // 
            this.WorkTime_Label.AutoSize = true;
            this.WorkTime_Label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WorkTime_Label.Location = new System.Drawing.Point(334, 15);
            this.WorkTime_Label.Name = "WorkTime_Label";
            this.WorkTime_Label.Size = new System.Drawing.Size(72, 16);
            this.WorkTime_Label.TabIndex = 10;
            this.WorkTime_Label.Text = "勤務時間";
            // 
            // EndTime_Second_Label
            // 
            this.EndTime_Second_Label.AutoSize = true;
            this.EndTime_Second_Label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndTime_Second_Label.Location = new System.Drawing.Point(270, 41);
            this.EndTime_Second_Label.Name = "EndTime_Second_Label";
            this.EndTime_Second_Label.Size = new System.Drawing.Size(24, 16);
            this.EndTime_Second_Label.TabIndex = 9;
            this.EndTime_Second_Label.Text = "分";
            // 
            // EndTime_Hour_Label
            // 
            this.EndTime_Hour_Label.AutoSize = true;
            this.EndTime_Hour_Label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndTime_Hour_Label.Location = new System.Drawing.Point(200, 41);
            this.EndTime_Hour_Label.Name = "EndTime_Hour_Label";
            this.EndTime_Hour_Label.Size = new System.Drawing.Size(24, 16);
            this.EndTime_Hour_Label.TabIndex = 8;
            this.EndTime_Hour_Label.Text = "時";
            // 
            // StartTime_Second_Label
            // 
            this.StartTime_Second_Label.AutoSize = true;
            this.StartTime_Second_Label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartTime_Second_Label.Location = new System.Drawing.Point(270, 15);
            this.StartTime_Second_Label.Name = "StartTime_Second_Label";
            this.StartTime_Second_Label.Size = new System.Drawing.Size(24, 16);
            this.StartTime_Second_Label.TabIndex = 7;
            this.StartTime_Second_Label.Text = "分";
            // 
            // StartTime_Hour_Label
            // 
            this.StartTime_Hour_Label.AutoSize = true;
            this.StartTime_Hour_Label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartTime_Hour_Label.Location = new System.Drawing.Point(200, 15);
            this.StartTime_Hour_Label.Name = "StartTime_Hour_Label";
            this.StartTime_Hour_Label.Size = new System.Drawing.Size(24, 16);
            this.StartTime_Hour_Label.TabIndex = 6;
            this.StartTime_Hour_Label.Text = "時";
            // 
            // EndTime_Label
            // 
            this.EndTime_Label.AutoSize = true;
            this.EndTime_Label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndTime_Label.Location = new System.Drawing.Point(43, 40);
            this.EndTime_Label.Name = "EndTime_Label";
            this.EndTime_Label.Size = new System.Drawing.Size(104, 16);
            this.EndTime_Label.TabIndex = 5;
            this.EndTime_Label.Text = "勤務終了時刻";
            // 
            // StartTime_Label
            // 
            this.StartTime_Label.AutoSize = true;
            this.StartTime_Label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartTime_Label.Location = new System.Drawing.Point(43, 16);
            this.StartTime_Label.Name = "StartTime_Label";
            this.StartTime_Label.Size = new System.Drawing.Size(104, 16);
            this.StartTime_Label.TabIndex = 4;
            this.StartTime_Label.Text = "勤務開始時間";
            // 
            // EndTime_Second_Combobox
            // 
            this.EndTime_Second_Combobox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.EndTime_Second_Combobox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndTime_Second_Combobox.FormattingEnabled = true;
            this.EndTime_Second_Combobox.Items.AddRange(new object[] {
            "0",
            "15",
            "30",
            "45"});
            this.EndTime_Second_Combobox.Location = new System.Drawing.Point(223, 38);
            this.EndTime_Second_Combobox.Name = "EndTime_Second_Combobox";
            this.EndTime_Second_Combobox.Size = new System.Drawing.Size(41, 24);
            this.EndTime_Second_Combobox.TabIndex = 3;
            this.EndTime_Second_Combobox.Tag = "";
            this.EndTime_Second_Combobox.Text = "30";
            this.EndTime_Second_Combobox.SelectedIndexChanged += new System.EventHandler(this.EndTime_Second_Combobox_SelectedIndexChanged);
            // 
            // EndTime_Hour_Combobox
            // 
            this.EndTime_Hour_Combobox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.EndTime_Hour_Combobox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndTime_Hour_Combobox.FormattingEnabled = true;
            this.EndTime_Hour_Combobox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.EndTime_Hour_Combobox.Location = new System.Drawing.Point(153, 38);
            this.EndTime_Hour_Combobox.Name = "EndTime_Hour_Combobox";
            this.EndTime_Hour_Combobox.Size = new System.Drawing.Size(41, 24);
            this.EndTime_Hour_Combobox.TabIndex = 2;
            this.EndTime_Hour_Combobox.Tag = "";
            this.EndTime_Hour_Combobox.Text = "17";
            this.EndTime_Hour_Combobox.SelectedIndexChanged += new System.EventHandler(this.EndTime_Hour_Combobox_SelectedIndexChanged);
            // 
            // StartTime_Second_Combobox
            // 
            this.StartTime_Second_Combobox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StartTime_Second_Combobox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartTime_Second_Combobox.FormattingEnabled = true;
            this.StartTime_Second_Combobox.Items.AddRange(new object[] {
            "0",
            "15",
            "30",
            "45"});
            this.StartTime_Second_Combobox.Location = new System.Drawing.Point(223, 12);
            this.StartTime_Second_Combobox.Name = "StartTime_Second_Combobox";
            this.StartTime_Second_Combobox.Size = new System.Drawing.Size(41, 24);
            this.StartTime_Second_Combobox.TabIndex = 1;
            this.StartTime_Second_Combobox.Tag = "";
            this.StartTime_Second_Combobox.Text = "45";
            this.StartTime_Second_Combobox.SelectedIndexChanged += new System.EventHandler(this.StartTime_Second_Combobox_SelectedIndexChanged);
            // 
            // StartTime_Hour_Combobox
            // 
            this.StartTime_Hour_Combobox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StartTime_Hour_Combobox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartTime_Hour_Combobox.FormattingEnabled = true;
            this.StartTime_Hour_Combobox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.StartTime_Hour_Combobox.Location = new System.Drawing.Point(153, 12);
            this.StartTime_Hour_Combobox.Name = "StartTime_Hour_Combobox";
            this.StartTime_Hour_Combobox.Size = new System.Drawing.Size(41, 24);
            this.StartTime_Hour_Combobox.TabIndex = 0;
            this.StartTime_Hour_Combobox.Tag = "";
            this.StartTime_Hour_Combobox.Text = "8";
            this.StartTime_Hour_Combobox.SelectedIndexChanged += new System.EventHandler(this.StartTime_Hour_Combobox_SelectedIndexChanged);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(322, 300);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(40, 29);
            this.Add_Button.TabIndex = 5;
            this.Add_Button.Text = "↑";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(381, 300);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(40, 29);
            this.Delete_Button.TabIndex = 6;
            this.Delete_Button.Text = "×";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // TotalWorkTime_Label
            // 
            this.TotalWorkTime_Label.AutoSize = true;
            this.TotalWorkTime_Label.Location = new System.Drawing.Point(648, 308);
            this.TotalWorkTime_Label.Name = "TotalWorkTime_Label";
            this.TotalWorkTime_Label.Size = new System.Drawing.Size(53, 12);
            this.TotalWorkTime_Label.TabIndex = 7;
            this.TotalWorkTime_Label.Text = "合計時間";
            // 
            // TotalWorkTime_Textbox
            // 
            this.TotalWorkTime_Textbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TotalWorkTime_Textbox.Location = new System.Drawing.Point(717, 305);
            this.TotalWorkTime_Textbox.Name = "TotalWorkTime_Textbox";
            this.TotalWorkTime_Textbox.ReadOnly = true;
            this.TotalWorkTime_Textbox.Size = new System.Drawing.Size(97, 19);
            this.TotalWorkTime_Textbox.TabIndex = 15;
            this.TotalWorkTime_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // workDetail_groupBox
            // 
            this.workDetail_groupBox.Controls.Add(this.Description_Textbox);
            this.workDetail_groupBox.Controls.Add(this.Description_Label);
            this.workDetail_groupBox.Controls.Add(this.WokTime_DomainUpDown);
            this.workDetail_groupBox.Controls.Add(this.SearchBusiness_Button);
            this.workDetail_groupBox.Controls.Add(this.SerarchProject_Button);
            this.workDetail_groupBox.Controls.Add(this.TaskName_TextBox);
            this.workDetail_groupBox.Controls.Add(this.TaskCode_Textbox);
            this.workDetail_groupBox.Controls.Add(this.ProjectName_Textbox);
            this.workDetail_groupBox.Controls.Add(this.ProjectCode_Textbox);
            this.workDetail_groupBox.Controls.Add(this.Time_Label);
            this.workDetail_groupBox.Controls.Add(this.Task_Label);
            this.workDetail_groupBox.Controls.Add(this.Project_Label);
            this.workDetail_groupBox.Location = new System.Drawing.Point(34, 330);
            this.workDetail_groupBox.Name = "workDetail_groupBox";
            this.workDetail_groupBox.Size = new System.Drawing.Size(780, 104);
            this.workDetail_groupBox.TabIndex = 16;
            this.workDetail_groupBox.TabStop = false;
            this.workDetail_groupBox.Text = "業務詳細入力";
            // 
            // Description_Textbox
            // 
            this.Description_Textbox.Location = new System.Drawing.Point(242, 66);
            this.Description_Textbox.Name = "Description_Textbox";
            this.Description_Textbox.Size = new System.Drawing.Size(448, 19);
            this.Description_Textbox.TabIndex = 23;
            // 
            // Description_Label
            // 
            this.Description_Label.AutoSize = true;
            this.Description_Label.Location = new System.Drawing.Point(207, 69);
            this.Description_Label.Name = "Description_Label";
            this.Description_Label.Size = new System.Drawing.Size(29, 12);
            this.Description_Label.TabIndex = 22;
            this.Description_Label.Text = "説明";
            // 
            // WokTime_DomainUpDown
            // 
            this.WokTime_DomainUpDown.Items.Add("0.00");
            this.WokTime_DomainUpDown.Items.Add("0.25");
            this.WokTime_DomainUpDown.Items.Add("0.50");
            this.WokTime_DomainUpDown.Items.Add("0.75");
            this.WokTime_DomainUpDown.Items.Add("1.00");
            this.WokTime_DomainUpDown.Items.Add("1.25");
            this.WokTime_DomainUpDown.Items.Add("1.50");
            this.WokTime_DomainUpDown.Items.Add("1.75");
            this.WokTime_DomainUpDown.Items.Add("2.00");
            this.WokTime_DomainUpDown.Items.Add("2.25");
            this.WokTime_DomainUpDown.Items.Add("2.50");
            this.WokTime_DomainUpDown.Items.Add("2.75");
            this.WokTime_DomainUpDown.Items.Add("3.00");
            this.WokTime_DomainUpDown.Items.Add("3.25");
            this.WokTime_DomainUpDown.Items.Add("3.50");
            this.WokTime_DomainUpDown.Items.Add("3.75");
            this.WokTime_DomainUpDown.Items.Add("4.00");
            this.WokTime_DomainUpDown.Items.Add("4.25");
            this.WokTime_DomainUpDown.Items.Add("4.50");
            this.WokTime_DomainUpDown.Items.Add("4.75");
            this.WokTime_DomainUpDown.Items.Add("5.00");
            this.WokTime_DomainUpDown.Items.Add("5.25");
            this.WokTime_DomainUpDown.Items.Add("5.50");
            this.WokTime_DomainUpDown.Items.Add("5.75");
            this.WokTime_DomainUpDown.Items.Add("6.00");
            this.WokTime_DomainUpDown.Items.Add("6.25");
            this.WokTime_DomainUpDown.Items.Add("6.50");
            this.WokTime_DomainUpDown.Items.Add("6.75");
            this.WokTime_DomainUpDown.Items.Add("7.00");
            this.WokTime_DomainUpDown.Items.Add("7.25");
            this.WokTime_DomainUpDown.Items.Add("7.50");
            this.WokTime_DomainUpDown.Items.Add("7.75");
            this.WokTime_DomainUpDown.Items.Add("8.00");
            this.WokTime_DomainUpDown.Items.Add("8.25");
            this.WokTime_DomainUpDown.Items.Add("8.50");
            this.WokTime_DomainUpDown.Items.Add("8.75");
            this.WokTime_DomainUpDown.Items.Add("9.00");
            this.WokTime_DomainUpDown.Items.Add("9.25");
            this.WokTime_DomainUpDown.Items.Add("9.50");
            this.WokTime_DomainUpDown.Items.Add("9.75");
            this.WokTime_DomainUpDown.Items.Add("10.00");
            this.WokTime_DomainUpDown.Items.Add("10.25");
            this.WokTime_DomainUpDown.Items.Add("10.50");
            this.WokTime_DomainUpDown.Items.Add("10.75");
            this.WokTime_DomainUpDown.Items.Add("11.00");
            this.WokTime_DomainUpDown.Items.Add("11.25");
            this.WokTime_DomainUpDown.Items.Add("11.50");
            this.WokTime_DomainUpDown.Items.Add("11.75");
            this.WokTime_DomainUpDown.Items.Add("12.00");
            this.WokTime_DomainUpDown.Items.Add("12.25");
            this.WokTime_DomainUpDown.Items.Add("12.50");
            this.WokTime_DomainUpDown.Items.Add("12.75");
            this.WokTime_DomainUpDown.Items.Add("13.00");
            this.WokTime_DomainUpDown.Items.Add("13.25");
            this.WokTime_DomainUpDown.Items.Add("13.50");
            this.WokTime_DomainUpDown.Items.Add("13.75");
            this.WokTime_DomainUpDown.Items.Add("14.00");
            this.WokTime_DomainUpDown.Items.Add("14.25");
            this.WokTime_DomainUpDown.Items.Add("14.50");
            this.WokTime_DomainUpDown.Items.Add("14.75");
            this.WokTime_DomainUpDown.Items.Add("15.00");
            this.WokTime_DomainUpDown.Items.Add("15.25");
            this.WokTime_DomainUpDown.Items.Add("15.50");
            this.WokTime_DomainUpDown.Items.Add("15.75");
            this.WokTime_DomainUpDown.Items.Add("16.00");
            this.WokTime_DomainUpDown.Items.Add("16.25");
            this.WokTime_DomainUpDown.Items.Add("16.50");
            this.WokTime_DomainUpDown.Items.Add("16.75");
            this.WokTime_DomainUpDown.Items.Add("17.00");
            this.WokTime_DomainUpDown.Items.Add("17.25");
            this.WokTime_DomainUpDown.Items.Add("17.50");
            this.WokTime_DomainUpDown.Items.Add("17.75");
            this.WokTime_DomainUpDown.Items.Add("18.00");
            this.WokTime_DomainUpDown.Items.Add("18.25");
            this.WokTime_DomainUpDown.Items.Add("18.50");
            this.WokTime_DomainUpDown.Items.Add("18.75");
            this.WokTime_DomainUpDown.Items.Add("19.00");
            this.WokTime_DomainUpDown.Items.Add("19.25");
            this.WokTime_DomainUpDown.Items.Add("19.50");
            this.WokTime_DomainUpDown.Items.Add("19.75");
            this.WokTime_DomainUpDown.Items.Add("20.00");
            this.WokTime_DomainUpDown.Items.Add("20.25");
            this.WokTime_DomainUpDown.Items.Add("20.50");
            this.WokTime_DomainUpDown.Items.Add("20.75");
            this.WokTime_DomainUpDown.Items.Add("21.00");
            this.WokTime_DomainUpDown.Items.Add("21.25");
            this.WokTime_DomainUpDown.Items.Add("21.50");
            this.WokTime_DomainUpDown.Items.Add("21.75");
            this.WokTime_DomainUpDown.Items.Add("22.00");
            this.WokTime_DomainUpDown.Items.Add("22.25");
            this.WokTime_DomainUpDown.Items.Add("22.50");
            this.WokTime_DomainUpDown.Items.Add("22.75");
            this.WokTime_DomainUpDown.Items.Add("23.00");
            this.WokTime_DomainUpDown.Items.Add("23.25");
            this.WokTime_DomainUpDown.Items.Add("23.50");
            this.WokTime_DomainUpDown.Items.Add("23.75");
            this.WokTime_DomainUpDown.Items.Add("24.00");
            this.WokTime_DomainUpDown.Items.Add("24.25");
            this.WokTime_DomainUpDown.Items.Add("25.50");
            this.WokTime_DomainUpDown.Items.Add("26.75");
            this.WokTime_DomainUpDown.Items.Add("27.00");
            this.WokTime_DomainUpDown.Items.Add("27.25");
            this.WokTime_DomainUpDown.Items.Add("27.50");
            this.WokTime_DomainUpDown.Items.Add("27.75");
            this.WokTime_DomainUpDown.Items.Add("28.00");
            this.WokTime_DomainUpDown.Items.Add("28.25");
            this.WokTime_DomainUpDown.Items.Add("28.50");
            this.WokTime_DomainUpDown.Items.Add("28.75");
            this.WokTime_DomainUpDown.Items.Add("29.00");
            this.WokTime_DomainUpDown.Items.Add("29.25");
            this.WokTime_DomainUpDown.Items.Add("29.50");
            this.WokTime_DomainUpDown.Items.Add("29.75");
            this.WokTime_DomainUpDown.Items.Add("30.00");
            this.WokTime_DomainUpDown.Location = new System.Drawing.Point(101, 66);
            this.WokTime_DomainUpDown.Name = "WokTime_DomainUpDown";
            this.WokTime_DomainUpDown.Size = new System.Drawing.Size(100, 19);
            this.WokTime_DomainUpDown.TabIndex = 21;
            this.WokTime_DomainUpDown.Text = "7.75";
            this.WokTime_DomainUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SearchBusiness_Button
            // 
            this.SearchBusiness_Button.Location = new System.Drawing.Point(696, 41);
            this.SearchBusiness_Button.Name = "SearchBusiness_Button";
            this.SearchBusiness_Button.Size = new System.Drawing.Size(75, 23);
            this.SearchBusiness_Button.TabIndex = 20;
            this.SearchBusiness_Button.Text = "検索";
            this.SearchBusiness_Button.UseVisualStyleBackColor = true;
            this.SearchBusiness_Button.Click += new System.EventHandler(this.SearchBusiness_Button_Click);
            // 
            // SerarchProject_Button
            // 
            this.SerarchProject_Button.Location = new System.Drawing.Point(696, 14);
            this.SerarchProject_Button.Name = "SerarchProject_Button";
            this.SerarchProject_Button.Size = new System.Drawing.Size(75, 23);
            this.SerarchProject_Button.TabIndex = 19;
            this.SerarchProject_Button.Text = "検索";
            this.SerarchProject_Button.UseVisualStyleBackColor = true;
            this.SerarchProject_Button.Click += new System.EventHandler(this.SerarchProject_Button_Click);
            // 
            // TaskName_TextBox
            // 
            this.TaskName_TextBox.Location = new System.Drawing.Point(207, 43);
            this.TaskName_TextBox.Name = "TaskName_TextBox";
            this.TaskName_TextBox.ReadOnly = true;
            this.TaskName_TextBox.Size = new System.Drawing.Size(483, 19);
            this.TaskName_TextBox.TabIndex = 18;
            // 
            // TaskCode_Textbox
            // 
            this.TaskCode_Textbox.Location = new System.Drawing.Point(101, 41);
            this.TaskCode_Textbox.Name = "TaskCode_Textbox";
            this.TaskCode_Textbox.ReadOnly = true;
            this.TaskCode_Textbox.Size = new System.Drawing.Size(100, 19);
            this.TaskCode_Textbox.TabIndex = 17;
            // 
            // ProjectName_Textbox
            // 
            this.ProjectName_Textbox.Location = new System.Drawing.Point(207, 18);
            this.ProjectName_Textbox.Name = "ProjectName_Textbox";
            this.ProjectName_Textbox.ReadOnly = true;
            this.ProjectName_Textbox.Size = new System.Drawing.Size(483, 19);
            this.ProjectName_Textbox.TabIndex = 16;
            // 
            // ProjectCode_Textbox
            // 
            this.ProjectCode_Textbox.Location = new System.Drawing.Point(101, 18);
            this.ProjectCode_Textbox.Name = "ProjectCode_Textbox";
            this.ProjectCode_Textbox.ReadOnly = true;
            this.ProjectCode_Textbox.Size = new System.Drawing.Size(100, 19);
            this.ProjectCode_Textbox.TabIndex = 15;
            // 
            // Time_Label
            // 
            this.Time_Label.AutoSize = true;
            this.Time_Label.Location = new System.Drawing.Point(66, 69);
            this.Time_Label.Name = "Time_Label";
            this.Time_Label.Size = new System.Drawing.Size(29, 12);
            this.Time_Label.TabIndex = 2;
            this.Time_Label.Text = "時間";
            // 
            // Task_Label
            // 
            this.Task_Label.AutoSize = true;
            this.Task_Label.Location = new System.Drawing.Point(66, 46);
            this.Task_Label.Name = "Task_Label";
            this.Task_Label.Size = new System.Drawing.Size(29, 12);
            this.Task_Label.TabIndex = 1;
            this.Task_Label.Text = "業務";
            // 
            // Project_Label
            // 
            this.Project_Label.AutoSize = true;
            this.Project_Label.Location = new System.Drawing.Point(39, 25);
            this.Project_Label.Name = "Project_Label";
            this.Project_Label.Size = new System.Drawing.Size(56, 12);
            this.Project_Label.TabIndex = 0;
            this.Project_Label.Text = "プロジェクト";
            // 
            // Remark_Label
            // 
            this.Remark_Label.AutoSize = true;
            this.Remark_Label.Location = new System.Drawing.Point(41, 446);
            this.Remark_Label.Name = "Remark_Label";
            this.Remark_Label.Size = new System.Drawing.Size(29, 12);
            this.Remark_Label.TabIndex = 23;
            this.Remark_Label.Text = "備考";
            // 
            // Remark_Textbox
            // 
            this.Remark_Textbox.Location = new System.Drawing.Point(76, 440);
            this.Remark_Textbox.Name = "Remark_Textbox";
            this.Remark_Textbox.Size = new System.Drawing.Size(738, 19);
            this.Remark_Textbox.TabIndex = 24;
            // 
            // Regist_Button
            // 
            this.Regist_Button.Location = new System.Drawing.Point(658, 466);
            this.Regist_Button.Name = "Regist_Button";
            this.Regist_Button.Size = new System.Drawing.Size(75, 23);
            this.Regist_Button.TabIndex = 25;
            this.Regist_Button.Text = "登録";
            this.Regist_Button.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(739, 465);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 26;
            this.Cancel_Button.Text = "キャンセル";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.DataPropertyName = "ID";
            this.ID_TextBox.HeaderText = "ID";
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.ReadOnly = true;
            this.ID_TextBox.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "プロジェクト名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // task_TextBox
            // 
            this.task_TextBox.DataPropertyName = "name1";
            this.task_TextBox.HeaderText = "業務名";
            this.task_TextBox.Name = "task_TextBox";
            this.task_TextBox.ReadOnly = true;
            this.task_TextBox.Width = 300;
            // 
            // note_TextBox
            // 
            this.note_TextBox.DataPropertyName = "note";
            this.note_TextBox.HeaderText = "備考";
            this.note_TextBox.Name = "note_TextBox";
            this.note_TextBox.ReadOnly = true;
            this.note_TextBox.Width = 200;
            // 
            // time_TextBox
            // 
            this.time_TextBox.DataPropertyName = "times";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.time_TextBox.DefaultCellStyle = dataGridViewCellStyle1;
            this.time_TextBox.HeaderText = "時間";
            this.time_TextBox.Name = "time_TextBox";
            this.time_TextBox.ReadOnly = true;
            this.time_TextBox.Width = 80;
            // 
            // projectID_TextBox
            // 
            this.projectID_TextBox.DataPropertyName = "ID1";
            this.projectID_TextBox.HeaderText = "プロジェクトID";
            this.projectID_TextBox.Name = "projectID_TextBox";
            this.projectID_TextBox.ReadOnly = true;
            this.projectID_TextBox.Visible = false;
            // 
            // taskID_TextBox
            // 
            this.taskID_TextBox.DataPropertyName = "ID2";
            this.taskID_TextBox.HeaderText = "タスクID";
            this.taskID_TextBox.Name = "taskID_TextBox";
            this.taskID_TextBox.ReadOnly = true;
            this.taskID_TextBox.Visible = false;
            // 
            // DailyReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 504);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Regist_Button);
            this.Controls.Add(this.Remark_Textbox);
            this.Controls.Add(this.Remark_Label);
            this.Controls.Add(this.workDetail_groupBox);
            this.Controls.Add(this.TotalWorkTime_Textbox);
            this.Controls.Add(this.TotalWorkTime_Label);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Calender_Label);
            this.Controls.Add(this.WorkDetail_DateGridView);
            this.Name = "DailyReportWindow";
            this.Text = "日報入力";
            this.Load += new System.EventHandler(this.DailyReportWindow_Load);
            this.Shown += new System.EventHandler(this.DailyReportWindow_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.WorkDetail_DateGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.workDetail_groupBox.ResumeLayout(false);
            this.workDetail_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WorkDetail_DateGridView;
        private System.Windows.Forms.Label Calender_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox StartTime_Hour_Combobox;
        private System.Windows.Forms.Label EndTime_Label;
        private System.Windows.Forms.Label StartTime_Label;
        private System.Windows.Forms.ComboBox EndTime_Second_Combobox;
        private System.Windows.Forms.ComboBox EndTime_Hour_Combobox;
        private System.Windows.Forms.ComboBox StartTime_Second_Combobox;
        private System.Windows.Forms.TextBox RestTime_Textbox;
        private System.Windows.Forms.TextBox WorkTime_Textbox;
        private System.Windows.Forms.Label NightOverTime_Label;
        private System.Windows.Forms.Label RestTime_Label;
        private System.Windows.Forms.Label NormalOverTime_Label;
        private System.Windows.Forms.Label WorkTime_Label;
        private System.Windows.Forms.Label EndTime_Second_Label;
        private System.Windows.Forms.Label EndTime_Hour_Label;
        private System.Windows.Forms.Label StartTime_Second_Label;
        private System.Windows.Forms.Label StartTime_Hour_Label;
        private System.Windows.Forms.TextBox NightOverTime_Textbox;
        private System.Windows.Forms.TextBox NormalOverTime_Textbox;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Label TotalWorkTime_Label;
        private System.Windows.Forms.TextBox TotalWorkTime_Textbox;
        private System.Windows.Forms.GroupBox workDetail_groupBox;
        private System.Windows.Forms.TextBox TaskName_TextBox;
        private System.Windows.Forms.TextBox TaskCode_Textbox;
        private System.Windows.Forms.TextBox ProjectName_Textbox;
        private System.Windows.Forms.TextBox ProjectCode_Textbox;
        private System.Windows.Forms.Label Time_Label;
        private System.Windows.Forms.Label Task_Label;
        private System.Windows.Forms.Label Project_Label;
        private System.Windows.Forms.TextBox Description_Textbox;
        private System.Windows.Forms.Label Description_Label;
        private System.Windows.Forms.DomainUpDown WokTime_DomainUpDown;
        private System.Windows.Forms.Button SearchBusiness_Button;
        private System.Windows.Forms.Button SerarchProject_Button;
        private System.Windows.Forms.Label Remark_Label;
        private System.Windows.Forms.TextBox Remark_Textbox;
        private System.Windows.Forms.Button Regist_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn task_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn note_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectID_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskID_TextBox;
    }
}