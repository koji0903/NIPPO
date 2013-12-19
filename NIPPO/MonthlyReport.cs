using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Data;
using System.Data.SqlClient;

namespace NIPPO
{
    public class MonthlyReport
    {
        // 変数
        private int _FY; // 年度
        private int _month; // 月
        private string _userID; // ユーザID

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="FY"></param>
        /// <param name="userID"></param>
        public MonthlyReport(int FY, string userID)
        {
            _FY = FY;
            this._month = DateTime.Now.Month;
            _userID = userID;
        }

        /// <summary>
        /// 設定値の「月」を強制的に指定する。テスト用。
        /// </summary>
        /// <param name="month"></param>
        public void setMonth(int month)
        {
            _month = month;
        }

        /// <summary>
        /// 設定値の「カレンダーイヤー」を返す。
        /// </summary>
        /// <returns></returns>
        public int getCalYear()
        {
            if (this._month >= 1 &&
                this._month <= 3)
                return this._FY + 1;
            else
                return this._FY;
        }

        /// <summary>
        /// 設定値の「カレンダーイヤー/月」を"YYYY年MM年"形式で返す
        /// </summary>
        /// <returns>String "YYYY年MM月"</returns>
        public string getStringYearMonth()
        {
            return this.getCalYear() + "年" +
                   this._month.ToString("D2") + "月";
        }
        /// <summary>
        /// 月をカウントアップする。年度なので12の次は1で、3が最大値。
        /// </summary>
        public void incrMonth()
        {
            if (this._month == 12)
                this._month = 1;
            else if (this._month == 3)
                this._month = 3;
            else
                this._month++;
        }

        /// <summary>
        /// 月をカウントダウンする。年度なので1の前は12で、4が最小値。
        /// </summary>
        public void decrMonth()
        {
            if (this._month == 1)
                this._month = 12;
            else if (this._month == 4)
                this._month = 4;
            else
                this._month--;
        }

        /// <summary>
        /// 年度内に次の月があるか
        /// </summary>
        /// <returns></returns>
        public bool existsNextMonth()
        {
            if (this._month == 3)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 年度内に前の月があるか
        /// </summary>
        /// <returns></returns>
        public bool existsPrevMonth()
        {
            if (this._month == 4)
                return false;
            else
                return true;
        }

        public string getUserName()
        {
            string str = "";
            DataSet ds = getUserNameOnStatusBarDs(this._userID);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                str = ds.Tables["user"].Rows[0]["lastname"] + " "
                    + ds.Tables["user"].Rows[0]["firstname"] + "("
                    + ds.Tables["user"].Rows[0]["name"] + ")";
            }
            
            return str;
        }

        internal DataSet getUserNameOnStatusBarDs(string userID)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            DataSet ds = new DataSet();

            connection.ConnectionString = NIPPO.Properties.Settings.Default.ConnectionString;

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT lastname,firstname,name"
                        + " FROM users LEFT JOIN sections"
                        + " ON users.sections_ID = sections.ID"
                        + " WHERE login='"
                        + userID + "';";
                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "user");
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            return ds;
        }
    }
}
