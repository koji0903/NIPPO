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
        [Test]
        public void login_test()
        {
            Login _lg;

            // 正常系
            _lg = new Login( "1", "1234" );
            Assert.AreEqual( 1, _lg.LoginFunction() );

            _lg = new Login("1", "1");
            Assert.AreEqual(-1, _lg.LoginFunction());

            _lg = new Login("1234", "1");
            Assert.AreEqual(-2, _lg.LoginFunction());

            //_dr = new DailyReport(2013, 1, 2013, 1, 2);
            //Assert.AreEqual("2013年01月02日(水)", _dr.GetDateStr());

        }

    
    
    }
}
