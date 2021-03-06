﻿namespace NIPPO
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cord_TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.業務内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.略名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TasksGridView
            // 
            this.TasksGridView.AllowUserToAddRows = false;
            this.TasksGridView.AllowUserToDeleteRows = false;
            this.TasksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cord_TextBox,
            this.業務内容,
            this.略名});
            this.TasksGridView.Location = new System.Drawing.Point(15, 63);
            this.TasksGridView.MultiSelect = false;
            this.TasksGridView.Name = "TasksGridView";
            this.TasksGridView.ReadOnly = true;
            this.TasksGridView.RowHeadersVisible = false;
            this.TasksGridView.RowTemplate.Height = 21;
            this.TasksGridView.RowTemplate.ReadOnly = true;
            this.TasksGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TasksGridView.Size = new System.Drawing.Size(476, 196);
            this.TasksGridView.TabIndex = 0;
            this.TasksGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TasksGridView_CellContentClick);
            // 
            // SelectButton
            // 
            this.SelectButton.ForeColor = System.Drawing.Color.Black;
            this.SelectButton.Location = new System.Drawing.Point(317, 265);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(84, 24);
            this.SelectButton.TabIndex = 1;
            this.SelectButton.Text = "選択";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(407, 265);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(84, 24);
            this.Cancel_Button.TabIndex = 2;
            this.Cancel_Button.Text = "キャンセル";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.ForeColor = System.Drawing.Color.Black;
            this.Search_Button.Location = new System.Drawing.Point(391, 33);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(47, 24);
            this.Search_Button.TabIndex = 3;
            this.Search_Button.Text = "検索";
            this.Search_Button.UseVisualStyleBackColor = true;
            // 
            // Clear_Button
            // 
            this.Clear_Button.ForeColor = System.Drawing.Color.Black;
            this.Clear_Button.Location = new System.Drawing.Point(444, 33);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(47, 24);
            this.Clear_Button.TabIndex = 4;
            this.Clear_Button.Text = "クリア";
            this.Clear_Button.UseVisualStyleBackColor = true;
            // 
            // Category_Label
            // 
            this.Category_Label.AutoSize = true;
            this.Category_Label.Location = new System.Drawing.Point(12, 43);
            this.Category_Label.Name = "Category_Label";
            this.Category_Label.Size = new System.Drawing.Size(35, 12);
            this.Category_Label.TabIndex = 5;
            this.Category_Label.Text = "分類：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(53, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 20);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 19);
            this.textBox1.TabIndex = 7;
            // 
            // Search_Label
            // 
            this.Search_Label.AutoSize = true;
            this.Search_Label.Location = new System.Drawing.Point(12, 9);
            this.Search_Label.Name = "Search_Label";
            this.Search_Label.Size = new System.Drawing.Size(29, 12);
            this.Search_Label.TabIndex = 8;
            this.Search_Label.Text = "検索";
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 25;
            // 
            // cord_TextBox
            // 
            this.cord_TextBox.DataPropertyName = "code";
            this.cord_TextBox.HeaderText = "コード";
            this.cord_TextBox.Name = "cord_TextBox";
            this.cord_TextBox.ReadOnly = true;
            this.cord_TextBox.Width = 70;
            // 
            // 業務内容
            // 
            this.業務内容.DataPropertyName = "name";
            this.業務内容.HeaderText = "業務内容";
            this.業務内容.Name = "業務内容";
            this.業務内容.ReadOnly = true;
            this.業務内容.Width = 260;
            // 
            // 略名
            // 
            this.略名.DataPropertyName = "alias";
            this.略名.HeaderText = "略名";
            this.略名.Name = "略名";
            this.略名.ReadOnly = true;
            this.略名.Width = 140;
            // 
            // SearchTasksWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 305);
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
            this.Load += new System.EventHandler(this.SearchTasksWindow_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.TasksGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Label Category_Label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Search_Label;
        private System.Windows.Forms.DataGridView TasksGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cord_TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn 業務内容;
        private System.Windows.Forms.DataGridViewTextBoxColumn 略名;
    }
}