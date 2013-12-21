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
        internal static DataSet ReadData(string str)
        {
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

        /// <summary>
        /// SqlCommandを作る関すう
        /// </summary>
        /// <returns></returns>
        internal SqlCommand ConnectDB()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = String.Format(NIPPO.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;
        }

        /// <summary>
        /// WorkDetail情報の取得
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

            int id;

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                try
                {
                    SqlCommand command = new SqlCommand();
                    command = ConnectDB();
                    id = GetUsersID(userID);
                    // データ取得
                    command.CommandText = @"SELECT projects.ID, projects.name, tasks.name, work_detail.note, work_detail.times " +
                         "FROM work_detail " +
                         "INNER JOIN projects ON work_detail.projects_ID = projects.ID " +
                         "INNER JOIN tasks ON work_detail.tasks_ID = tasks.ID";
                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "WorkDetail");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return ds;
        }

        /// <summary>
        /// ログイン変数で与えられた時の場合に、テーブルのIDを取得する関数（テスト用）
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        internal int GetUsersID(String login)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                try
                {
                    DataSet ds = new DataSet();
                    string SqlCommand = "SELECT ID,password FROM users WHERE login='" + login + "';";
                    ds = ReadData(SqlCommand);
                    return (int)ds.Tables[0].Rows[0]["ID"];
                }
                catch( Exception ex )
                {
                    // usersテーブルにloginが指定されなかった場合（Loginウィンドウでチェックされているのでこのケースはないはず）
                    MessageBox.Show(ex.Message);
                }
            }
            return 0;
        }

        // 追加 これがないとエラーになる（よく分からん）
        #region IDisposable メンバー

        public void Dispose()
        {
        }

        #endregion
    }
}
