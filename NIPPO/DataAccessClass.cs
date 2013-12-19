using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Data;
using System.Data.SqlClient;

namespace NIPPO
{
    class DataAccessClass : IDisposable
    {
        internal DataSet GetTitleDs(String userID, String password, String keyword)
        {
            //(1) SqlConnectionクラスを使ってSQL Serverに接続
            //(2) SqlCommandクラスを使って、「title LIKE @Title」というLIKE演算子とパラメータ（＝WHERE句）によるあいまい検索を行うSELECT文を作成
            //(3) SqlParameterクラスで「@Title」に「%＜キーワード＞%」を設定
            //(4) SqlDataAdapterクラスでSELECT文を実行して、データセットに結果を格納
            //(5) データセットのテーブルに主キー（＝PrimaryKeyプロパティの値）を設定
            DataSet ds = new DataSet();
            using (SqlConnection _cn = new SqlConnection())
            {
                //_cn.ConnectionString = String.Format(NIPPO.Properties.Settings.Default.ConnectionString,
                //    userID, password);
                _cn.ConnectionString = String.Format(NIPPO.Properties.Settings.Default.ConnectionString,userID,password);
                _cn.Open();
                _cn.Close();


                using (SqlCommand _cmd = new SqlCommand())
                //using (MySqlCommand _cmd = new MySqlCommand())
                {
                    _cmd.Connection = _cn;
                    _cmd.CommandText = @"SELECT * " +
                                        "FROM users";
                    using (SqlDataAdapter _da = new SqlDataAdapter())
                    {
                        _da.SelectCommand = _cmd;
                        _da.Fill(ds, "UserList");
                        ds.Tables["UserList"].PrimaryKey = new DataColumn[] { ds.Tables["UserList"].Columns["ID"] };
                    }
                }
            }
            return ds;
        }

        // 追加 これがないとエラーになる（よく分からん）
        #region IDisposable メンバー

        public void Dispose()
        {
        }

        #endregion
    }
}
