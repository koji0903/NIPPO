using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NIPPO;
using System.Data;
using System.Data.SqlClient;

namespace NIPPO_test
{
    // 追加：[TestFixture]で、テスト用のクラスであることを宣言
    [TestFixture]
    class Main_test
    {
        private string ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=nippo_db;User ID=nippo;password=KSK1217";
        private string testLoginNo = "4";
        private string dummyLoginNo = "5";

        private int getUserID(string login)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            DataSet ds = new DataSet();

            connection.ConnectionString = this.ConnectionString;

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT ID"
                        + " FROM users"
                        + " WHERE login='" + login + "';";
                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "user");
                }
                catch
                {
                    return -1;
                }
            }
            return int.Parse(ds.Tables["user"].Rows[0]["ID"].ToString());
        }

        [Test]
        public void ユーザID異常系のテスト()
        {
            // コンストラクタで落とす
            Main _mo = new Main(-1);
            // 例外を出さずに返ること
            Assert.AreEqual("不明なユーザ", _mo.getUserName());
        }

        [Test]
        public void ユーザ名文字列のテスト()
        {
            int userID = this.getUserID(testLoginNo);
            Main _mo = new Main(userID);
            Assert.AreEqual("櫻木 誠(総務部)", _mo.getUserName());
            // sectionが取れない場合
            userID = this.getUserID(dummyLoginNo);
            _mo = new Main(userID);
            Assert.AreEqual("櫻木 ダミー()", _mo.getUserName());
        }

    }
}


