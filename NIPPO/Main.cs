using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Data;
using System.Data.SqlClient;

namespace NIPPO
{
    class Main
    {
        private int _userID; // ユーザID

        public Main(int userID)
        {
            _userID = userID;
        }

        public string getUserName()
        {
            string str = "不明なユーザ";
            DataSet ds = getUserNameOnStatusBarDs(this._userID);
            DataRowCollection aaa = ds.Tables["user"].Rows;
            if (ds.Tables["user"] != null &&
                ds.Tables["user"].Rows.Count > 0)
            {
                str = ds.Tables["user"].Rows[0]["lastname"] + " "
                    + ds.Tables["user"].Rows[0]["firstname"] + "("
                    + ds.Tables["user"].Rows[0]["name"] + ")";
            }
            return str;
        }

        public DataSet getUserNameOnStatusBarDs(int userID)
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
                        + " WHERE users.ID='"
                        + userID + "';";
                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "user");
                }
                catch
                {
                    return ds;
                }
            }
            return ds;
        }
    }
}
