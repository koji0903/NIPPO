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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sections_ID_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calender_Label = new System.Windows.Forms.Label();
            this.StartTime_Lavel = new System.Windows.Forms.Label();
            this.EndTime_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TextBox,
            this.lastname_TextBox,
            this.sections_ID_TextBox});
            this.dataGridView1.Location = new System.Drawing.Point(34, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(865, 148);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.DataPropertyName = "ID";
            this.ID_TextBox.HeaderText = "あいでぃー";
            this.ID_TextBox.Name = "ID_TextBox";
            // 
            // lastname_TextBox
            // 
            this.lastname_TextBox.DataPropertyName = "lastname";
            this.lastname_TextBox.HeaderText = "らすとねーむ";
            this.lastname_TextBox.Name = "lastname_TextBox";
            // 
            // sections_ID_TextBox
            // 
            this.sections_ID_TextBox.DataPropertyName = "sections_ID";
            this.sections_ID_TextBox.HeaderText = "せくしょんずあいでぃー";
            this.sections_ID_TextBox.Name = "sections_ID_TextBox";
            // 
            // Calender_Label
            // 
            this.Calender_Label.AutoSize = true;
            this.Calender_Label.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Calender_Label.Location = new System.Drawing.Point(281, 9);
            this.Calender_Label.Name = "Calender_Label";
            this.Calender_Label.Size = new System.Drawing.Size(341, 33);
            this.Calender_Label.TabIndex = 1;
            this.Calender_Label.Text = "YYYY年MM月DD日（曜）";
            this.Calender_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartTime_Lavel
            // 
            this.StartTime_Lavel.AutoSize = true;
            this.StartTime_Lavel.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartTime_Lavel.Location = new System.Drawing.Point(56, 66);
            this.StartTime_Lavel.Name = "StartTime_Lavel";
            this.StartTime_Lavel.Size = new System.Drawing.Size(129, 20);
            this.StartTime_Lavel.TabIndex = 2;
            this.StartTime_Lavel.Text = "勤務開始時刻";
            // 
            // EndTime_Label
            // 
            this.EndTime_Label.AutoSize = true;
            this.EndTime_Label.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndTime_Label.Location = new System.Drawing.Point(56, 97);
            this.EndTime_Label.Name = "EndTime_Label";
            this.EndTime_Label.Size = new System.Drawing.Size(129, 20);
            this.EndTime_Label.TabIndex = 3;
            this.EndTime_Label.Text = "勤務終了時刻";
            // 
            // DailyReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 420);
            this.Controls.Add(this.EndTime_Label);
            this.Controls.Add(this.StartTime_Lavel);
            this.Controls.Add(this.Calender_Label);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DailyReportWindow";
            this.Text = "日報入力";
            this.Load += new System.EventHandler(this.DailyReportWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn sections_ID_TextBox;
        private System.Windows.Forms.Label Calender_Label;
        private System.Windows.Forms.Label StartTime_Lavel;
        private System.Windows.Forms.Label EndTime_Label;
    }
}