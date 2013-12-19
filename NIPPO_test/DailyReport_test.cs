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
        [Test]
        public void GetDateStr_test()
        {
            DailyReport _daily = new DailyReport();
            // 正常系
            Assert.AreEqual("2013年01月01日(火)", _daily.GetDateStr(2013, 1, 1));
            Assert.AreEqual("2013年01月02日(水)", _daily.GetDateStr(2013, 1, 2));
            Assert.AreEqual("2013年01月03日(木)", _daily.GetDateStr(2013, 1, 3));
            Assert.AreEqual("2013年01月04日(金)", _daily.GetDateStr(2013, 1, 4));
            Assert.AreEqual("2013年01月05日(土)", _daily.GetDateStr(2013, 1, 5));
            Assert.AreEqual("2013年01月06日(日)", _daily.GetDateStr(2013, 1, 6));
            Assert.AreEqual("2013年01月07日(月)", _daily.GetDateStr(2013, 1, 7));
            Assert.AreEqual("2011年10月10日(月)", _daily.GetDateStr(2011, 10, 10));
            Assert.AreEqual("2013年12月31日(火)", _daily.GetDateStr(2013, 12, 31));
            Assert.AreEqual("2015年03月20日(金)", _daily.GetDateStr(2015, 03, 20));
            // 異常系
            Assert.AreEqual("2013年00月00日(無効な年月日)", _daily.GetDateStr(2013, 0, 0));
            Assert.AreEqual("0000年00月00日(無効な年月日)", _daily.GetDateStr(0, 0, 0));
        }

        [Test]
        public void GetWorkTime_test()
        {
            DailyReport _daily = new DailyReport();
            // 正常系のテスト

            // 通常勤務（休憩は昼休みのみ）
            string[] work = _daily.GetWorkTime(8, 45, 17, 30);
            string[] ary = { "7.75h", "1.00h", "0.00h", "0.00h" };
            Assert.AreEqual(ary, work);

            // 残業（休憩は昼休み＋夕方）
            work = _daily.GetWorkTime(8, 45, 18, 00);
            ary[0] = "7.75h";
            ary[1] = "1.50h";
            ary[2] = "7.75h";
            ary[3] = "7.75h";
            Assert.AreEqual(ary, work);


            
            //            work = _daily.GetWorkTime(2013, 12, 17, 1, 0, 2, 0);
//            ary[0] = "1.00h";
//            ary[1] = "1.00h";
//            ary[2] = "1.00h";
//            ary[3] = "1.00h";
//            Assert.AreEqual(ary, work);
            
//            Assert.AreEqual("1.25h", _daily.GetWorkTime(2013, 12, 17, 1, 0, 2, 15));
//            Assert.AreEqual("1.50h", _daily.GetWorkTime(2013, 12, 17, 1, 0, 2, 30));
//            Assert.AreEqual("1.75h", _daily.GetWorkTime(2013, 12, 17, 1, 0, 2, 45));
//            Assert.AreEqual("8.00h", _daily.GetWorkTime(2013, 12, 17, 8, 0, 17, 0));
//            Assert.AreEqual("1.25h", _daily.GetWorkTime(2013, 12, 17, 8, 0, 21, 15));
//            Assert.AreEqual("1.50h", _daily.GetWorkTime(2013, 12, 17, 8, 0, 22, 30));
//            Assert.AreEqual("1.75h", _daily.GetWorkTime(2013, 12, 17, 8, 0, 23, 45));
        }
    }
}
