using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NIPPO;
using System.Data;

namespace NIPPO_test
{
    // 追加：[TestFixture]で、テスト用のクラスであることを宣言
    [TestFixture]
    class MonthlyReport_test
    {
        // 追加：ここにイチからテストを書く
        [Test]
        public void コンストラクタのテスト()
        {
            // どうテストすればいいか不明。後で。
            MonthlyReport _mr = new MonthlyReport(2013,"1");
            //Assert.
        }

        [Test]
        public void カレンダーイヤー計算のテスト()
        {
            MonthlyReport _mr = new MonthlyReport(2013, "1");
            _mr.setMonth(4);
            Assert.AreEqual(2013, _mr.getCalYear());
            _mr.setMonth(12);
            Assert.AreEqual(2013, _mr.getCalYear());
            _mr.setMonth(1);
            Assert.AreEqual(2014, _mr.getCalYear());
            _mr.setMonth(2);
            Assert.AreEqual(2014, _mr.getCalYear());
            _mr.setMonth(3);
            Assert.AreEqual(2014, _mr.getCalYear());
        }

        [Test]
        public void 年月の文字列生成のテスト()
        {
            MonthlyReport _mr = new MonthlyReport(2013, "1");
            _mr.setMonth(4);
            Assert.AreEqual("2013年04月", _mr.getStringYearMonth());
            _mr.setMonth(11);
            Assert.AreEqual("2013年11月", _mr.getStringYearMonth());
            _mr.setMonth(3);
            Assert.AreEqual("2014年03月", _mr.getStringYearMonth());
        }

        [Test]
        public void 月カウントアップのテスト()
        {
            MonthlyReport _mr = new MonthlyReport(2013, "1");
            _mr.setMonth(11);
            _mr.incrMonth();
            Assert.AreEqual("2013年12月", _mr.getStringYearMonth());
            _mr.incrMonth();
            Assert.AreEqual("2014年01月", _mr.getStringYearMonth());
            // はみ出してもカウントせず、エラーにもならないこと
            _mr.setMonth(3);
            _mr.incrMonth();
            Assert.AreEqual("2014年03月", _mr.getStringYearMonth());
        }

        [Test]
        public void 次の月があるかのテスト()
        {
            MonthlyReport _mr = new MonthlyReport(2013, "1");
            _mr.setMonth(4);
            Assert.AreEqual(true, _mr.existsNextMonth());
            _mr.setMonth(12);
            Assert.AreEqual(true, _mr.existsNextMonth());
            _mr.setMonth(1);
            Assert.AreEqual(true, _mr.existsNextMonth());
            _mr.setMonth(3);
            Assert.AreEqual(false, _mr.existsNextMonth());
        }

        [Test]
        public void 前の月があるかのテスト()
        {
            MonthlyReport _mr = new MonthlyReport(2013, "1");
            _mr.setMonth(3);
            Assert.AreEqual(true, _mr.existsPrevMonth());
            _mr.setMonth(1);
            Assert.AreEqual(true, _mr.existsPrevMonth());
            _mr.setMonth(12);
            Assert.AreEqual(true, _mr.existsPrevMonth());
            _mr.setMonth(4);
            Assert.AreEqual(false, _mr.existsPrevMonth());
        }

        [Test]
        public void とりあえずテスト()
        {
            MonthlyReport _mr = new MonthlyReport(2013, "1");
            _mr.setMonth(12);
            DataSet _ds = _mr.getMonthlyWorkReport("MonthlyReport");
            
            Assert.AreEqual(true, _ds.Tables["MonthlyReport"].Rows[0]["day"]);
        }
    }
}
