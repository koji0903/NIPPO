namespace NIPPO
{
    partial class SearchTasksWindow
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
            this.TasksGridView = new System.Windows.Forms.DataGridView();
            this.SelectButton = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Category_Label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TasksGridView
            // 
            this.TasksGridView.AllowUserToAddRows = false;
            this.TasksGridView.AllowUserToDeleteRows = false;
            this.TasksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksGridView.Location = new System.Drawing.Point(19, 77);
            this.TasksGridView.Name = "TasksGridView";
            this.TasksGridView.ReadOnly = true;
            this.TasksGridView.RowTemplate.Height = 21;
            this.TasksGridView.Size = new System.Drawing.Size(546, 196);
            this.TasksGridView.TabIndex = 0;
            this.TasksGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TasksGridView_CellContentClick);
            // 
            // SelectButton
            // 
            this.SelectButton.ForeColor = System.Drawing.Color.Black;
            this.SelectButton.Location = new System.Drawing.Point(391, 284);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(84, 24);
            this.SelectButton.TabIndex = 1;
            this.SelectButton.Text = "選択";
            this.SelectButton.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(481, 284);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(84, 24);
            this.Cancel_Button.TabIndex = 2;
            this.Cancel_Button.Text = "キャンセル";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Search_Button
            // 
            this.Search_Button.ForeColor = System.Drawing.Color.Black;
            this.Search_Button.Location = new System.Drawing.Point(465, 38);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(47, 24);
            this.Search_Button.TabIndex = 3;
            this.Search_Button.Text = "検索";
            this.Search_Button.UseVisualStyleBackColor = true;
            // 
            // Clear_Button
            // 
            this.Clear_Button.ForeColor = System.Drawing.Color.Black;
            this.Clear_Button.Location = new System.Drawing.Point(518, 38);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(47, 24);
            this.Clear_Button.TabIndex = 4;
            this.Clear_Button.Text = "クリア";
            this.Clear_Button.UseVisualStyleBackColor = true;
            // 
            // Category_Label
            // 
            this.Category_Label.AutoSize = true;
            this.Category_Label.Location = new System.Drawing.Point(27, 39);
            this.Category_Label.Name = "Category_Label";
            this.Category_Label.Size = new System.Drawing.Size(35, 12);
            this.Category_Label.TabIndex = 5;
            this.Category_Label.Text = "分類：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 20);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 19);
            this.textBox1.TabIndex = 7;
            // 
            // Search_Label
            // 
            this.Search_Label.AutoSize = true;
            this.Search_Label.Location = new System.Drawing.Point(27, 9);
            this.Search_Label.Name = "Search_Label";
            this.Search_Label.Size = new System.Drawing.Size(29, 12);
            this.Search_Label.TabIndex = 8;
            this.Search_Label.Text = "検索";
            // 
            // SearchTasksWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 324);
            this.Controls.Add(this.Search_Label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Category_Label);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.TasksGridView);
            this.Name = "SearchTasksWindow";
            this.Text = "業務検索";
            ((System.ComponentModel.ISupportInitialize)(this.TasksGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TasksGridView;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Label Category_Label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Search_Label;
    }
}