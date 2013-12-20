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
    /// <summary>
    ///  ログイン機能
    /// </summary>
    class Login : IDisposable
    {

        internal static int login(string login,string pw)
        {

            // ログインエラーコード
            int iderror = -1;
            int pwerror = -2;

            string SqlCommand = "SELECT ID,password FROM users WHERE login='" + login + "';";
            DataSet ds = new DataSet(); 
            ds = DataAccess.ReadData( SqlCommand );

            // IDの存在、およびパスワード一致の確認。
            if ( ds.Tables[0].Rows.Count == 1 )
            {
                string str = ds.Tables[0].Rows[0]["password"].ToString();
                if ( str == pw )
                {
                    //ログイン成功 ID(primary key)を返す。
                    return (int)ds.Tables[0].Rows[0]["ID"];
                }
                else
                {
                    //パスワードが間違っている場合。
                    return iderror;
                }
            }
            else
            {
                // IDが間違っている場合。
                return pwerror;
            }
        }

        #region IDisposable
        public void Dispose()
        {
        }
        #endregion
    }
}



