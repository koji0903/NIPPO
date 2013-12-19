using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NIPPO
{
    class DataAccessClass : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="work_time"></param>
        /// <returns></returns>
        internal DataSet GetWorkDetailDs(String userID, int year, int month, int day, Double work_time)
        {
            // データ保存用のDateSet作成
            DataSet ds = new DataSet();

            // SQLとの接続
            using ( SqlConnection connection = new SqlConnection() )
            {
                // DBとのユーザ認証設定
                connection.ConnectionString = NIPPO.Properties.Settings.Default.ConnectionString;
                using ( SqlCommand command = new SqlCommand() )
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        try
                        {
                            command.Connection = connection;
                            command.CommandText = @"SELECT * FROM work_detail;";

                            adapter.SelectCommand = command;
                            adapter.Fill(ds, "WorkDetail");
                        }
                        catch ( Exception ex )
                        {
                            MessageBox.Show(ex.Message);
                        }
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
