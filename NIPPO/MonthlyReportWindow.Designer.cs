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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(535, 497);
            this.dataGridView1.TabIndex = 2;
            // 
            // MonthlyReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 652);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_prevMonth);
            this.Controls.Add(this.button_nextMonth);
            this.Controls.Add(this.label_FTMonth);
            this.Name = "MonthlyReportWindow";
            this.Text = "MonthlyReportWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FTMonth;
        private System.Windows.Forms.Button button_nextMonth;
        private System.Windows.Forms.Button button_prevMonth;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}