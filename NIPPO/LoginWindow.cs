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
        public string userID;
        private string userPW;

        public LoginWindow()
        {
            InitializeComponent();
        }


        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            userID = this.id_textbox.Text;
            userPW = this.pw_textbox.Text;

            if (Login.login(userID, userPW) == true)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
                MessageBox.Show("IDまたはパスワードが違います。");
                this.id_textbox.Text = null;
                this.pw_textbox.Text = null;
            }
        }
    }
}
