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
    public class Login : IDisposable
    {

        private string _id;
        private string _pw;
        private DataSet _ds;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Login( string loginname, string password)
        {
            this._id = loginname;
            this._pw = password;
            this._ds = new DataSet(); 
        }

        public int LoginFunction()
        {

            // ログインエラーコード
            int iderror = -1;
            int pwerror = -2;

            string SqlCommand = "SELECT ID,password FROM users WHERE login='" + this._id + "';";
            this._ds = DataAccess.ReadData( SqlCommand );

            // IDの存在、およびパスワード一致の確認。
            if ( this._ds.Tables[0].Rows.Count == 1 )
            {
                string str = this._ds.Tables[0].Rows[0]["password"].ToString();
                if ( str == this._pw )
                {
                    //ログイン成功 ID(primary key)を返す。
                    return (int)this._ds.Tables[0].Rows[0]["ID"];
                }
                else
                {
                    //パスワードが間違っている場合。
                    return pwerror;
                }
            }
            else
            {
                // IDが間違っている場合。
                return iderror;
            }
        }

        #region IDisposable
        public void Dispose()
        {
        }
        #endregion
    }
}



