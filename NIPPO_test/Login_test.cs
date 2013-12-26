using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NIPPO;


namespace NIPPO_test
{
    // 追加：[TestFixture]で、テスト用のクラスであることを宣言
    [TestFixture]
    public class Login_test
    {
        /// <summary>
        /// 設定したID・PWでログインができることの確認
        /// </summary>
        [Test]
        public void login_test()
        {
            Login _lg;

            _lg = new Login("1", "1234");
            Assert.AreEqual(1, _lg.LoginFunction());

            _lg = new Login("4", "1234");
            Assert.AreEqual(4, _lg.LoginFunction());

            _lg = new Login("6", "goal");
            Assert.AreEqual(6, _lg.LoginFunction());

            _lg = new Login("7", "@-!=?");
            Assert.AreEqual(7, _lg.LoginFunction());

            _lg = new Login("10", "0123");
            Assert.AreEqual(8, _lg.LoginFunction());

            _lg = new Login("01", "Kakitani");
            Assert.AreEqual(9, _lg.LoginFunction());

            _lg = new Login("02", "ほたる");
            Assert.AreEqual(10, _lg.LoginFunction());

            _lg = new Login("001", "");
            Assert.AreEqual(11, _lg.LoginFunction());

            _lg = new Login("002", "岡崎");
            Assert.AreEqual(12, _lg.LoginFunction());

            _lg = new Login("003", "Zac@0401");
            Assert.AreEqual(13, _lg.LoginFunction());

            _lg = new Login("7204382", "Naoki.Otani");
            Assert.AreEqual(14, _lg.LoginFunction());

        }

        /// <summary>
        /// ログインテスト　IDエラーチェック
        /// </summary>
        [Test]
        public void login_iderror_test()
        {
            Login _lg;

            _lg = new Login("", "");
            Assert.AreEqual(-1, _lg.LoginFunction());

            _lg = new Login("999", "");
            Assert.AreEqual(-1, _lg.LoginFunction());

            _lg = new Login("川島", "Kawashima");
            Assert.AreEqual(-1, _lg.LoginFunction());

        }

        /// <summary>
        /// ログインテスト　PWエラーチェック
        /// </summary>
        [Test]
        public void login_pwerror_test()
        {
            Login _lg;

            _lg = new Login("7204382", "");
            Assert.AreEqual(-2, _lg.LoginFunction());

            _lg = new Login("7204382", "naoki.otani");
            Assert.AreEqual(-2, _lg.LoginFunction());

            _lg = new Login("7204382", "大谷直毅");
            Assert.AreEqual(-2, _lg.LoginFunction());
      
        }
    

    
    }
}
