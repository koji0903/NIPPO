using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace NIPPO
{
    class Login : IDisposable
    {

        internal static Boolean login(string userID,string userPW)
        {
            //Login認証
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            DataSet ds = new DataSet();

            connection.ConnectionString = NIPPO.Properties.Settings.Default.ConnectionString;
            //connection.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=nippo_db;User Id=nippo;Password=KSK1217;";

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT ID,password FROM users WHERE ID='" + userID + "';";

                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "user");
                    // IDが間違っていた場合の処理

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //終了処理が必要？
                }
            }

            // IDの存在、およびパスワード一致の確認。
            if ( ds.Tables["user"].Rows.Count == 1 )
            {
                string str = ds.Tables["user"].Rows[0]["password"].ToString();
                if ( str == userPW )
                {
                    //ログイン成功
                    return true;
                }
                else
                {
                    //パスワードが間違っている場合。
                    return false;
                }
            }
            else
            {
                // IDが間違っている場合。
                return false;
            }
        }

        #region IDisposable
        public void Dispose()
        {
        }
        #endregion
    }
}



