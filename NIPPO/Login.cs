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
            Boolean result;

            connection.ConnectionString = NIPPO.Properties.Settings.Default.ConnectionString;
            //connection.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=nippo_db;User Id=nippo;Password=KSK1217;";

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT ID,password FROM users WHERE ID='" + userID + "';";

                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "pw");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //終了処理が必要？
                }
            }

            string str = ds.Tables["pw"].Rows[0]["password"].ToString();
            if( str == userPW )
            {
                return true;
            }
            else
            {
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



