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
            this.dataGridView1.Location = new System.Drawing.Point(33, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1153, 185);
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
            // DailyReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 415);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DailyReportWindow";
            this.Text = "日報入力";
            this.Load += new System.EventHandler(this.DailyReportWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn sections_ID_TextBox;
    }
}