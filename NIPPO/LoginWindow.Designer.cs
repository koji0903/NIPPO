namespace NIPPO
{
    partial class LoginWindow
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
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.pw_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.ID_label = new System.Windows.Forms.Label();
            this.PW_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(80, 34);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(134, 19);
            this.id_textbox.TabIndex = 0;
            // 
            // pw_textbox
            // 
            this.pw_textbox.Location = new System.Drawing.Point(80, 71);
            this.pw_textbox.Name = "pw_textbox";
            this.pw_textbox.PasswordChar = '*';
            this.pw_textbox.Size = new System.Drawing.Size(134, 19);
            this.pw_textbox.TabIndex = 1;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(80, 113);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(55, 21);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(159, 113);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(55, 21);
            this.clear_button.TabIndex = 3;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(31, 37);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(40, 12);
            this.ID_label.TabIndex = 4;
            this.ID_label.Text = "社員ID";
            // 
            // PW_label
            // 
            this.PW_label.AutoSize = true;
            this.PW_label.Location = new System.Drawing.Point(19, 74);
            this.PW_label.Name = "PW_label";
            this.PW_label.Size = new System.Drawing.Size(52, 12);
            this.PW_label.TabIndex = 5;
            this.PW_label.Text = "パスワード";
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.PW_label);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pw_textbox);
            this.Controls.Add(this.id_textbox);
            this.Name = "LoginWindow";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.TextBox pw_textbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label PW_label;
    }
}