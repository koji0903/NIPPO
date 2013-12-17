using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// 追加：参照設定へnunit.frameworkの追加も必要
using NUnit.Framework;
// 追加：参照設定へNIPPOクラスの追加も必要
using NIPPO;

namespace NIPPO_test
{
    // 追加：[TestFixture]で、テスト用のクラスであることを宣言
    [TestFixture]
    public class DailyReport_test
    {
        // 追加：ここにイチからテストを書く
        [Test]
        public void GetCalender_test()
        {
            DailyReport _daily = new DailyReport();
            Assert.AreEqual("2013年01月01日(火)", _daily.GetCalender(2013, 1, 1));
            Assert.AreEqual("2013年01月02日(水)", _daily.GetCalender(2013, 1, 2));
            Assert.AreEqual("2013年01月03日(木)", _daily.GetCalender(2013, 1, 3));
            Assert.AreEqual("2013年01月04日(金)", _daily.GetCalender(2013, 1, 4));
            Assert.AreEqual("2013年01月05日(土)", _daily.GetCalender(2013, 1, 5));
            Assert.AreEqual("2013年01月06日(日)", _daily.GetCalender(2013, 1, 6));
            Assert.AreEqual("2013年01月07日(月)", _daily.GetCalender(2013, 1, 7));
            Assert.AreEqual("2013年12月31日(火)", _daily.GetCalender(2013, 12, 31));
        }
    }
}
