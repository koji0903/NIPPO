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
        private string login;
        private string pw;
        public int id;

        public LoginWindow()
        {
            InitializeComponent();
        }


        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            login = this.id_textbox.Text;
            pw    = this.pw_textbox.Text;

            // login関数は、ログイン成功時ID (primary key)を返し、
            // ログイン失敗時は負の整数を返す。
            id    =Login.login(login, pw);
            if ( id > 0 )
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //this.DialogResult = DialogResult.Abort;
                MessageBox.Show("IDまたはパスワードが違います。");
                this.id_textbox.Text = null;
                this.pw_textbox.Text = null;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            this.id_textbox.Text = null;
            this.pw_textbox.Text = null;
        }

 


    }
}
