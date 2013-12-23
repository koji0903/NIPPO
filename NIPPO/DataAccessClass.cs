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
        /// データベースアクセス用の基本メソッド
        /// - 接続設定、オープン、データ取得、クローズ処理を行う
        /// </summary>
        /// <param name="str">SQL実行コマンド文字列</param>
        /// <returns>データセット</returns>
        internal static DataSet ReadData(string str, string table_name = null)
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
                    if (table_name == null)
                    {
                        adapter.Fill(ds);
                    }
                    else
                    {
                        adapter.Fill(ds,table_name);
                    }
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
        /// </summary>
        /// <param name="str">SQL実行コマンド文字列</param>
        /// <returns>データセット</returns>
        internal void Update(DataSet ds, String table_name)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            connection.ConnectionString = NIPPO.Properties.Settings.Default.ConnectionString;

            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM work_detail", connection))
            {
                try
                {
                    SqlCommandBuilder builder =new SqlCommandBuilder(adapter);
                    String update_cmd = builder.GetUpdateCommand().CommandText;
                    String delete_cmd = builder.GetDeleteCommand().CommandText;
                    adapter.Update(ds.Tables[table_name]);
                }
                catch (Exception ex)
                {
                    //  データベース接続が失敗した場合
                    MessageBox.Show(ex.Message);
                }
            }
        }


        /// <summary>
        /// SqlCommandを作る関数
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
        /// <returns></returns>
        internal DataSet GetWorkDetailDs(String userID, int year, int month, int day)
        {
            // データ保存用のDateSet作成
            DataSet ds = new DataSet();

            int id, work_report_id;

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                try
                {
                    SqlCommand command = new SqlCommand();
                    command = ConnectDB();
                    id = GetUsersID(userID);
                    work_report_id = GetWorkReportID(id, year, month, day);
                    // データ取得
                    ds.Clear();
                    command.CommandText = @"SELECT projects.ID, projects.name, tasks.name, work_detail.note, work_detail.times, work_reports_ID, projects_ID, tasks_ID " +
                         "FROM work_detail " +
                         "INNER JOIN projects ON work_detail.projects_ID = projects.ID " +
                         "INNER JOIN tasks ON work_detail.tasks_ID = tasks.ID " +
                         "WHERE work_detail.work_reports_ID = '" + work_report_id + "';";
                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "WorkDetail");
/*                    
                    // 始めての登録時は空の5行を追加
                    if (ds.Tables["WorkDetail"].Rows.Count == 0)
                    {
                        DataTable dt = ds.Tables["WorkDetail"];
                        DataRow dr = dt.NewRow();
                        dr["name"] = "";
                        for (int i = 0; i < 5; i++)
                        {
                            dr = dt.NewRow();
                            dt.Rows.Add(dr);
                        }
                    }
                    else if (ds.Tables["WorkDetail"].Rows.Count < 5)
                    {
                        DataTable dt = ds.Tables["WorkDetail"];
                        DataRow dr = dt.NewRow();
                        dr["name"] = "";
                        for (int i = 0; i < 6 - ds.Tables["WorkDetail"].Rows.Count; i++)
                        {
                            dr = dt.NewRow();
                            dt.Rows.Add(dr);
                        }
                    }
 */
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
            DataSet ds = new DataSet();
            string SqlCommand = "SELECT ID,password FROM users WHERE login='" + login + "';";
            try
            {
                ds = ReadData(SqlCommand);
                return (int)ds.Tables[0].Rows[0]["ID"];
            }
            catch( Exception ex )
            {
                // usersテーブルにloginが指定されなかった場合（Loginウィンドウでチェックされているのでこのケースはないはず）
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        /// <summary>
        /// WorkReport IDをDBから取得するメソッド
        /// </summary>
        /// <param name="userID">ユーザID</param>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <returns>WorkReportテーブルのデータベースID</returns>
        internal int GetWorkReportID(int userID, int year, int month, int day)
        {
            DataSet ds = new DataSet();
            string SqlCommand = "SELECT ID FROM work_reports WHERE users_ID = '" + 
                userID + "' AND year = '" + 
                year +"' AND month = '" + 
                month + "' AND day = '" + 
                day + "';";
            try
            {
                ds = ReadData(SqlCommand);
                if ( ds.Tables[0].Rows.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return (int)ds.Tables[0].Rows[0]["ID"];
                }
            }
            catch (Exception ex)
            {
                // usersテーブルにloginが指定されなかった場合（Loginウィンドウでチェックされているのでこのケースはないはず）
                MessageBox.Show(ex.Message);
            }
            return 0;
        }


        /// <summary>
        /// プロジェクトNoから、projectsテーブルのデータベースIDを取得するメソッド
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        internal int getProjectID(int num)
        {
            DataSet ds = new DataSet();
            string SqlCommand = "SELECT ID FROM projects WHERE num = '" + num + "'";
            try
            {
                ds = ReadData(SqlCommand,"projects");
                return (int)ds.Tables["projects"].Rows[0]["ID"];
            }
            catch (Exception ex)
            {
                // usersテーブルにloginが指定されなかった場合（Loginウィンドウでチェックされているのでこのケースはないはず）
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        /// <summary>
        /// タスクCodeから、tasksテーブルのデータベースIDを取得するメソッド
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        internal int getTaskID(int code)
        {
            DataSet ds = new DataSet();
            string SqlCommand = "SELECT ID FROM tasks WHERE code = '" + code + "'";
            try
            {
                ds = ReadData(SqlCommand, "tasks");
                return (int)ds.Tables["tasks"].Rows[0]["ID"];
            }
            catch (Exception ex)
            {
                // usersテーブルにloginが指定されなかった場合（Loginウィンドウでチェックされているのでこのケースはないはず）
                MessageBox.Show(ex.Message);
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
