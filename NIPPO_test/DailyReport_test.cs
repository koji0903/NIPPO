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
            DailyReport _dr;
            // 正常系
            _dr = new DailyReport(2013, 1, 2013, 1, 1);
            Assert.AreEqual("2013年01月01日(火)", _dr.GetDateStr());
            _dr = new DailyReport(2013, 1, 2013, 1, 2);
            Assert.AreEqual("2013年01月02日(水)", _dr.GetDateStr());
            _dr = new DailyReport(2013, 1, 2013, 1, 3);
            Assert.AreEqual("2013年01月03日(木)", _dr.GetDateStr());
            _dr = new DailyReport(2013, 1, 2013, 1, 4);
            Assert.AreEqual("2013年01月04日(金)", _dr.GetDateStr());
            _dr = new DailyReport(2013, 1, 2013, 1, 5);
            Assert.AreEqual("2013年01月05日(土)", _dr.GetDateStr());
            _dr = new DailyReport(2013, 1, 2013, 1, 6);
            Assert.AreEqual("2013年01月06日(日)", _dr.GetDateStr());
            _dr = new DailyReport(2013, 1, 2013, 1, 7);
            Assert.AreEqual("2013年01月07日(月)", _dr.GetDateStr());
            _dr = new DailyReport(2013, 1, 2011, 10, 10);
            Assert.AreEqual("2011年10月10日(月)", _dr.GetDateStr());
            _dr = new DailyReport(2013, 1, 2013, 12, 31);
            Assert.AreEqual("2013年12月31日(火)", _dr.GetDateStr());
            _dr = new DailyReport(2014, 1, 2015, 03, 20);
            Assert.AreEqual("2015年03月20日(金)", _dr.GetDateStr());
            // 異常系
            _dr = new DailyReport(2013,1,2013, 0, 0);
            Assert.AreEqual("2013年00月00日(無効な年月日)", _dr.GetDateStr());
            _dr = new DailyReport(2013,1,0, 0, 0);
            Assert.AreEqual("0000年00月00日(無効な年月日)", _dr.GetDateStr());
        }

        [Test]
        public void GetWorkTime_test()
        {
            DailyReport _dr = new DailyReport(2013, 1, 2013, 12, 8);
            // 正常系のテスト

            // 通常勤務（勤務＋昼休み休憩）
            double[] work = _dr.GetWorkTime(8, 45, 17, 30);
            double[] ary = { 7.75, 1.00, 0.00, 0.00 };
            Assert.AreEqual(ary, work);

            // 残業（勤務＋昼休み休憩＋夕方休憩）
            work = _dr.GetWorkTime(8, 45, 18, 00);
            ary[0] = 7.75;
            ary[1] = 1.50;
            ary[2] = 0.00;
            ary[3] = 0.00;
            Assert.AreEqual(ary, work);

            // 残業（勤務＋昼休み休憩＋夕方休憩＋普通残業）
            work = _dr.GetWorkTime(8, 45, 18, 15);
            ary[0] = 8.00;
            ary[1] = 1.50;
            ary[2] = 0.25;
            ary[3] = 0.00;
            Assert.AreEqual(ary, work);

            // 残業（勤務＋昼休み休憩＋夕方休憩＋普通残業＋深夜残業直前まで）
            work = _dr.GetWorkTime(8, 45, 22, 00);
            ary[0] = 11.75;
            ary[1] = 1.50;
            ary[2] = 4.00;
            ary[3] = 0.00;
            Assert.AreEqual(ary, work);

            // 残業（勤務＋昼休み休憩＋夕方休憩＋夜勤務＋普通残業＋深夜残業）
            work = _dr.GetWorkTime(8, 45, 24, 00);
            ary[0] = 13.75;
            ary[1] = 1.50;
            ary[2] = 4.00;
            ary[3] = 2.00;
            Assert.AreEqual(ary, work);

            // 残業（勤務＋昼休み休憩＋夕方休憩＋夜勤務＋普通残業＋深夜残業翌日）
            work = _dr.GetWorkTime(8, 45, 30, 00);
            ary[0] = 19.75;
            ary[1] = 1.50;
            ary[2] = 4.00;
            ary[3] = 8.00;
            Assert.AreEqual(ary, work);

            // 残業（勤務＋昼休み休憩＋夕方休憩＋夜勤務＋普通残業＋深夜残業翌日(MAX)）
            work = _dr.GetWorkTime(8, 45, 30, 45);
            ary[0] = 20.50;
            ary[1] = 1.50;
            ary[2] = 4.00;
            ary[3] = 8.75;
            Assert.AreEqual(ary, work);

            // 通常勤務（勤務＋早朝勤務＋昼休み休憩）
            work = _dr.GetWorkTime(6, 00, 17, 30);
            ary[0] = 10.50;
            ary[1] = 1.00;
            ary[2] = 2.75;
            ary[3] = 0.00;
            Assert.AreEqual(ary, work);

            // 通常勤務（勤務＋早朝勤務＋昼休み休憩）
            work = _dr.GetWorkTime(5, 00, 17, 30);
            ary[0] = 11.50;
            ary[1] = 1.00;
            ary[2] = 3.75;
            ary[3] = 0.00;
            Assert.AreEqual(ary, work);

            // 通常勤務（勤務＋午前休暇）
            work = _dr.GetWorkTime(8, 45, 12, 00);
            ary[0] = 3.25;
            ary[1] = 0.00;
            ary[2] = 0.00;
            ary[3] = 0.00;
            Assert.AreEqual(ary, work);

            // 通常勤務（勤務＋午後休暇）
            work = _dr.GetWorkTime(8, 45, 12, 30);
            ary[0] = 3.25;
            ary[1] = 0.50;
            ary[2] = 0.00;
            ary[3] = 0.00;
            Assert.AreEqual(ary, work);

            // 通常勤務（勤務＋午前休暇）
            work = _dr.GetWorkTime(13, 00, 17, 30);
            ary[0] = 4.50;
            ary[1] = 0.00;
            ary[2] = 0.00;
            ary[3] = 0.00;
            Assert.AreEqual(ary, work);

            // 通常勤務（勤務＋午前休暇＋残業） プリント用紙　ケース（１）
            work = _dr.GetWorkTime(13, 00, 20, 00);
            ary[0] = 6.50;
            ary[1] = 0.50;
            ary[2] = 0.00;
            ary[3] = 0.00;
            Assert.AreEqual(ary, work);

            // 通常勤務（勤務＋午前休暇＋残業） プリント用紙　ケース（２）
            work = _dr.GetWorkTime(9, 45, 20, 00);
            ary[0] = 8.75;
            ary[1] = 1.50;
            ary[2] = 1.00;
            ary[3] = 0.00;
            Assert.AreEqual(ary, work);

            // 通常勤務（勤務＋午前休暇＋残業） プリント用紙　ケース（２）
            work = _dr.GetWorkTime(9, 45, 20, 30);
            ary[0] = 9.25;
            ary[1] = 1.50;
            ary[2] = 1.50;
            ary[3] = 0.00;
            Assert.AreEqual(ary, work);

            // 通常勤務（勤務＋午前休暇＋残業） プリント用紙　ケース（３）
            work = _dr.GetWorkTime(13, 00, 23, 00);
            ary[0] = 9.50;
            ary[1] = 0.50;
            ary[2] = 0.75;
            ary[3] = 1.00;
            Assert.AreEqual(ary, work);

            // 通常勤務（勤務＋午前休暇＋残業） プリント用紙　ケース（３）
            work = _dr.GetWorkTime(13, 00, 23, 30);
            ary[0] = 10.00;
            ary[1] = 0.50;
            ary[2] = 0.75;
            ary[3] = 1.50;
            Assert.AreEqual(ary, work);

            // 通常勤務（勤務＋午前休暇＋残業） プリント用紙　ケース（３）
            work = _dr.GetWorkTime(13, 00, 24, 00);
            ary[0] = 10.50;
            ary[1] = 0.50;
            ary[2] = 0.75;
            ary[3] = 2.00;
            Assert.AreEqual(ary, work);

        }


        [Test]
        public void setHourText_test()
        {
            DailyReport _dr = new DailyReport(2013, 1, 2013, 12, 8);
            // 正常系のテスト
            Assert.AreEqual("2.00h", _dr.setHourText(2.0));
            Assert.AreEqual("0.00h", _dr.setHourText(0.0));
            Assert.AreEqual("0.00h", _dr.setHourText(0));
        }

        [Test]
        public void timeCompare_test()
        {
            DailyReport _dr = new DailyReport(2013, 1, 2013, 12, 8);
            _dr.work_time = 2.0;
            _dr.regist_time = 2.0;
            Assert.AreEqual("", _dr.timeCompare());
            _dr.work_time = 3.0;
            _dr.regist_time = 2.0;
            Assert.AreEqual("作業時間の割り当てが不足しています", _dr.timeCompare());
            _dr.work_time = 3.0;
            _dr.regist_time = 7.0;
            Assert.AreEqual("作業時間が勤務時間を超えています", _dr.timeCompare());
        }

        [Test]
        public void getTime_test()
        {
            DailyReport _dr = new DailyReport(2013, 1, 2013, 12, 8);
            Assert.AreEqual("2013/12/24 07:15:00", _dr.getTime(2013, 12, 24, 7, 15));
        }
    }
}
