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
            this.label_FTMonth = new System.Windows.Forms.Label();
            this.button_nextMonth = new System.Windows.Forms.Button();
            this.button_prevMonth = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox_summary = new System.Windows.Forms.GroupBox();
            this.label_totalTime = new System.Windows.Forms.Label();
            this.label_totalOverTime125 = new System.Windows.Forms.Label();
            this.label_totalOverTime150 = new System.Windows.Forms.Label();
            this.textBox_totalTime = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl_collection = new System.Windows.Forms.TabControl();
            this.tabPage_project = new System.Windows.Forms.TabPage();
            this.tabPage_work = new System.Windows.Forms.TabPage();
            this.groupBox_dailyWork = new System.Windows.Forms.GroupBox();
            this.button_outputExcel = new System.Windows.Forms.Button();
            this.button_closeWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_summary.SuspendLayout();
            this.tabControl_collection.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_FTMonth
            // 
            this.label_FTMonth.AutoSize = true;
            this.label_FTMonth.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.label_FTMonth.Location = new System.Drawing.Point(228, 22);
            this.label_FTMonth.Name = "label_FTMonth";
            this.label_FTMonth.Size = new System.Drawing.Size(170, 27);
            this.label_FTMonth.TabIndex = 0;
            this.label_FTMonth.Text = "YYYY年MM月";
            // 
            // button_nextMonth
            // 
            this.button_nextMonth.Location = new System.Drawing.Point(441, 22);
            this.button_nextMonth.Name = "button_nextMonth";
            this.button_nextMonth.Size = new System.Drawing.Size(29, 23);
            this.button_nextMonth.TabIndex = 1;
            this.button_nextMonth.Text = ">";
            this.button_nextMonth.UseVisualStyleBackColor = true;
            // 
            // button_prevMonth
            // 
            this.button_prevMonth.Location = new System.Drawing.Point(152, 22);
            this.button_prevMonth.Name = "button_prevMonth";
            this.button_prevMonth.Size = new System.Drawing.Size(29, 23);
            this.button_prevMonth.TabIndex = 1;
            this.button_prevMonth.Text = "<";
            this.button_prevMonth.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(560, 523);
            this.dataGridView1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 630);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1011, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox_summary
            // 
            this.groupBox_summary.Controls.Add(this.textBox2);
            this.groupBox_summary.Controls.Add(this.textBox1);
            this.groupBox_summary.Controls.Add(this.textBox_totalTime);
            this.groupBox_summary.Controls.Add(this.label_totalOverTime150);
            this.groupBox_summary.Controls.Add(this.label_totalOverTime125);
            this.groupBox_summary.Controls.Add(this.label_totalTime);
            this.groupBox_summary.Location = new System.Drawing.Point(613, 33);
            this.groupBox_summary.Name = "groupBox_summary";
            this.groupBox_summary.Size = new System.Drawing.Size(254, 140);
            this.groupBox_summary.TabIndex = 4;
            this.groupBox_summary.TabStop = false;
            this.groupBox_summary.Text = "集計";
            // 
            // label_totalTime
            // 
            this.label_totalTime.AutoSize = true;
            this.label_totalTime.Location = new System.Drawing.Point(47, 39);
            this.label_totalTime.Name = "label_totalTime";
            this.label_totalTime.Size = new System.Drawing.Size(67, 15);
            this.label_totalTime.TabIndex = 0;
            this.label_totalTime.Text = "勤務時間";
            this.label_totalTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_totalOverTime125
            // 
            this.label_totalOverTime125.AutoSize = true;
            this.label_totalOverTime125.Location = new System.Drawing.Point(17, 70);
            this.label_totalOverTime125.Name = "label_totalOverTime125";
            this.label_totalOverTime125.Size = new System.Drawing.Size(97, 15);
            this.label_totalOverTime125.TabIndex = 0;
            this.label_totalOverTime125.Text = "超過勤務時間";
            this.label_totalOverTime125.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_totalOverTime150
            // 
            this.label_totalOverTime150.AutoSize = true;
            this.label_totalOverTime150.Location = new System.Drawing.Point(17, 105);
            this.label_totalOverTime150.Name = "label_totalOverTime150";
            this.label_totalOverTime150.Size = new System.Drawing.Size(97, 15);
            this.label_totalOverTime150.TabIndex = 0;
            this.label_totalOverTime150.Text = "深夜勤務時間";
            this.label_totalOverTime150.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_totalTime
            // 
            this.textBox_totalTime.Location = new System.Drawing.Point(129, 36);
            this.textBox_totalTime.Name = "textBox_totalTime";
            this.textBox_totalTime.ReadOnly = true;
            this.textBox_totalTime.Size = new System.Drawing.Size(100, 22);
            this.textBox_totalTime.TabIndex = 1;
            this.textBox_totalTime.Text = "h";
            this.textBox_totalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "h";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "h";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabControl_collection
            // 
            this.tabControl_collection.Controls.Add(this.tabPage_project);
            this.tabControl_collection.Controls.Add(this.tabPage_work);
            this.tabControl_collection.Location = new System.Drawing.Point(613, 200);
            this.tabControl_collection.Name = "tabControl_collection";
            this.tabControl_collection.SelectedIndex = 0;
            this.tabControl_collection.Size = new System.Drawing.Size(386, 171);
            this.tabControl_collection.TabIndex = 5;
            // 
            // tabPage_project
            // 
            this.tabPage_project.Location = new System.Drawing.Point(4, 25);
            this.tabPage_project.Name = "tabPage_project";
            this.tabPage_project.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_project.Size = new System.Drawing.Size(378, 142);
            this.tabPage_project.TabIndex = 0;
            this.tabPage_project.Text = "プロジェクト別集計";
            this.tabPage_project.UseVisualStyleBackColor = true;
            // 
            // tabPage_work
            // 
            this.tabPage_work.Location = new System.Drawing.Point(4, 25);
            this.tabPage_work.Name = "tabPage_work";
            this.tabPage_work.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_work.Size = new System.Drawing.Size(378, 142);
            this.tabPage_work.TabIndex = 1;
            this.tabPage_work.Text = "業務別集計";
            this.tabPage_work.UseVisualStyleBackColor = true;
            // 
            // groupBox_dailyWork
            // 
            this.groupBox_dailyWork.Location = new System.Drawing.Point(617, 399);
            this.groupBox_dailyWork.Name = "groupBox_dailyWork";
            this.groupBox_dailyWork.Size = new System.Drawing.Size(377, 190);
            this.groupBox_dailyWork.TabIndex = 6;
            this.groupBox_dailyWork.TabStop = false;
            this.groupBox_dailyWork.Text = "1日の業務一覧";
            // 
            // button_outputExcel
            // 
            this.button_outputExcel.Location = new System.Drawing.Point(35, 598);
            this.button_outputExcel.Name = "button_outputExcel";
            this.button_outputExcel.Size = new System.Drawing.Size(101, 23);
            this.button_outputExcel.TabIndex = 7;
            this.button_outputExcel.Text = "Excel出力";
            this.button_outputExcel.UseVisualStyleBackColor = true;
            // 
            // button_closeWindow
            // 
            this.button_closeWindow.Location = new System.Drawing.Point(898, 598);
            this.button_closeWindow.Name = "button_closeWindow";
            this.button_closeWindow.Size = new System.Drawing.Size(101, 23);
            this.button_closeWindow.TabIndex = 7;
            this.button_closeWindow.Text = "閉じる";
            this.button_closeWindow.UseVisualStyleBackColor = true;
            // 
            // MonthlyReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 652);
            this.Controls.Add(this.button_closeWindow);
            this.Controls.Add(this.button_outputExcel);
            this.Controls.Add(this.groupBox_dailyWork);
            this.Controls.Add(this.tabControl_collection);
            this.Controls.Add(this.groupBox_summary);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_prevMonth);
            this.Controls.Add(this.button_nextMonth);
            this.Controls.Add(this.label_FTMonth);
            this.Name = "MonthlyReportWindow";
            this.Text = "MonthlyReportWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_summary.ResumeLayout(false);
            this.groupBox_summary.PerformLayout();
            this.tabControl_collection.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FTMonth;
        private System.Windows.Forms.Button button_nextMonth;
        private System.Windows.Forms.Button button_prevMonth;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox_summary;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_totalTime;
        private System.Windows.Forms.Label label_totalOverTime150;
        private System.Windows.Forms.Label label_totalOverTime125;
        private System.Windows.Forms.Label label_totalTime;
        private System.Windows.Forms.TabControl tabControl_collection;
        private System.Windows.Forms.TabPage tabPage_project;
        private System.Windows.Forms.TabPage tabPage_work;
        private System.Windows.Forms.GroupBox groupBox_dailyWork;
        private System.Windows.Forms.Button button_outputExcel;
        private System.Windows.Forms.Button button_closeWindow;
    }
}