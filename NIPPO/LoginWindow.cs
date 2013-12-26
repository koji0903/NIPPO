using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NIPPO
{
    public partial class LoginWindow : Form
    {
        public int _id;

        public LoginWindow()
        {
            InitializeComponent();
            // id 初期値
            this._id = 0;
        }


        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            // login関数は、ログイン成功時ID (primary key)を返し、
            // ログイン失敗時は負の整数を返す。
            using (Login _lg = new Login(this.id_textbox.Text, this.pw_textbox.Text))
            {
                this._id = _lg.LoginFunction();
                if (this._id > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    //this.DialogResult = DialogResult.Abort;
                    MessageBox.Show("IDまたはパスワードが違います。");
                    this._id = 0;
                    this.id_textbox.Text = null;
                    this.pw_textbox.Text = null;
                }
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            this.id_textbox.Text = null;
            this.pw_textbox.Text = null;
        }

 


    }
}
