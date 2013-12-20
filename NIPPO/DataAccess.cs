using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace NIPPO
{
    class DataAccess
    {
        internal static DataSet ReadData(string str)
        {

            //Login認証
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            DataSet ds = new DataSet();

            connection.ConnectionString = NIPPO.Properties.Settings.Default.ConnectionString;

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                try
                {
                    //　データベース接続設定
                    command.Connection = connection;
                    //　データ取得SQLコマンドの設定
                    command.CommandText = @str;
                    //  データ接続(open)、SQLコマンドの実行、切断（close）
                    adapter.SelectCommand = command;
                    adapter.Fill(ds);

                    // IDが間違っていた場合の処理
                }
                catch (Exception ex)
                {
                    //  データベース接続が失敗した場合
                    MessageBox.Show(ex.Message);
                    Environment.Exit(Environment.ExitCode);
                }
            }

            return ds;

        }
    }
}