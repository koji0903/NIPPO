namespace NIPPO
{
    partial class SearchProjectsWindow
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
            this.ProjectsGridView = new System.Windows.Forms.DataGridView();
            this.Select_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Search_label = new System.Windows.Forms.Label();
            this.fy_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fy_label = new System.Windows.Forms.Label();
            this.project_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search_Bottun = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fy_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectsGridView
            // 
            this.ProjectsGridView.AllowUserToAddRows = false;
            this.ProjectsGridView.AllowUserToDeleteRows = false;
            this.ProjectsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectsGridView.Location = new System.Drawing.Point(12, 56);
            this.ProjectsGridView.Name = "ProjectsGridView";
            this.ProjectsGridView.ReadOnly = true;
            this.ProjectsGridView.RowTemplate.Height = 21;
            this.ProjectsGridView.Size = new System.Drawing.Size(952, 278);
            this.ProjectsGridView.TabIndex = 0;
            this.ProjectsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Select_Button
            // 
            this.Select_Button.Location = new System.Drawing.Point(790, 340);
            this.Select_Button.Name = "Select_Button";
            this.Select_Button.Size = new System.Drawing.Size(84, 24);
            this.Select_Button.TabIndex = 1;
            this.Select_Button.Text = "選択";
            this.Select_Button.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Cancel_Button.Location = new System.Drawing.Point(880, 340);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(84, 24);
            this.Cancel_Button.TabIndex = 2;
            this.Cancel_Button.Text = "キャンセル";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Search_label
            // 
            this.Search_label.AutoSize = true;
            this.Search_label.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Search_label.Location = new System.Drawing.Point(12, 9);
            this.Search_label.Name = "Search_label";
            this.Search_label.Size = new System.Drawing.Size(37, 14);
            this.Search_label.TabIndex = 3;
            this.Search_label.Text = "検索";
            // 
            // fy_NumericUpDown
            // 
            this.fy_NumericUpDown.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fy_NumericUpDown.Location = new System.Drawing.Point(55, 28);
            this.fy_NumericUpDown.Name = "fy_NumericUpDown";
            this.fy_NumericUpDown.Size = new System.Drawing.Size(88, 21);
            this.fy_NumericUpDown.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(211, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // fy_label
            // 
            this.fy_label.AutoSize = true;
            this.fy_label.Location = new System.Drawing.Point(14, 37);
            this.fy_label.Name = "fy_label";
            this.fy_label.Size = new System.Drawing.Size(35, 12);
            this.fy_label.TabIndex = 6;
            this.fy_label.Text = "年度：";
            // 
            // project_label
            // 
            this.project_label.AutoSize = true;
            this.project_label.Location = new System.Drawing.Point(170, 37);
            this.project_label.Name = "project_label";
            this.project_label.Size = new System.Drawing.Size(35, 12);
            this.project_label.TabIndex = 7;
            this.project_label.Text = "事業：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(554, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 19);
            this.textBox1.TabIndex = 8;
            // 
            // Search_Bottun
            // 
            this.Search_Bottun.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Search_Bottun.Location = new System.Drawing.Point(790, 26);
            this.Search_Bottun.Name = "Search_Bottun";
            this.Search_Bottun.Size = new System.Drawing.Size(84, 24);
            this.Search_Bottun.TabIndex = 9;
            this.Search_Bottun.Text = "検索";
            this.Search_Bottun.UseVisualStyleBackColor = true;
            // 
            // Clear_Button
            // 
            this.Clear_Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Clear_Button.Location = new System.Drawing.Point(880, 26);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(84, 24);
            this.Clear_Button.TabIndex = 10;
            this.Clear_Button.Text = "クリア";
            this.Clear_Button.UseVisualStyleBackColor = true;
            // 
            // SearchProjectsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(976, 376);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Search_Bottun);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.project_label);
            this.Controls.Add(this.fy_label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fy_NumericUpDown);
            this.Controls.Add(this.Search_label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Select_Button);
            this.Controls.Add(this.ProjectsGridView);
            this.Name = "SearchProjectsWindow";
            this.Text = "プロジェクト検索";
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fy_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProjectsGridView;
        private System.Windows.Forms.Button Select_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label Search_label;
        private System.Windows.Forms.NumericUpDown fy_NumericUpDown;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label fy_label;
        private System.Windows.Forms.Label project_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search_Bottun;
        private System.Windows.Forms.Button Clear_Button;
    }
}