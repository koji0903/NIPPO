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
        private string listTableName = "MonthlyReport"; // ここはあえてベタ書きにしておく

        // 追加：ここにイチからテストを書く
        [Test]
        public void コンストラクタのテスト()
        {
            // どうテストすればいいか不明。後で。
            MonthlyReport _mr = new MonthlyReport(2013, 1);
            //Assert.
        }

        [Test]
        public void ユーザID異常系のテスト()
        {
            // コンストラクタで落とす
            MonthlyReport _mr = new MonthlyReport(2013, -1);
            // 例外を出さずに返ること
            Assert.AreEqual("不明なユーザ", _mr.getUserName());
            // 例外を出さずに返ること
            _mr.setMonth(12);
            DataSet _ds = _mr.getMonthlyWorkReport();
            Assert.AreEqual(1, _ds.Tables[this.listTableName].Rows[0]["day"]);
        }

        [Test]
        public void カレンダーイヤー計算のテスト()
        {
            MonthlyReport _mr = new MonthlyReport(2013, 1);
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
            MonthlyReport _mr = new MonthlyReport(2013, 1);
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
            MonthlyReport _mr = new MonthlyReport(2013, 1);
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
            MonthlyReport _mr = new MonthlyReport(2013, 1);
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
            MonthlyReport _mr = new MonthlyReport(2013, 1);
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
        public void DataSetがカレンダーになっているか()
        {
            MonthlyReport _mr = new MonthlyReport(2013, 1);
            _mr.setMonth(12);
            DataSet _ds = _mr.getMonthlyWorkReport();            
            Assert.AreEqual(1, _ds.Tables[this.listTableName].Rows[0]["day"]);
            Assert.AreEqual("日", _ds.Tables[this.listTableName].Rows[0]["week"]);
            Assert.AreEqual(31, _ds.Tables[this.listTableName].Rows[30]["day"]);
            Assert.AreEqual(31, _ds.Tables[this.listTableName].Rows.Count);
            _mr.setMonth(2);
            _ds = _mr.getMonthlyWorkReport();
            Assert.AreEqual(1, _ds.Tables[this.listTableName].Rows[0]["day"]);
            Assert.AreEqual("土", _ds.Tables[this.listTableName].Rows[0]["week"]);
            Assert.AreEqual(28, _ds.Tables[this.listTableName].Rows[27]["day"]);
            Assert.AreEqual(28, _ds.Tables[this.listTableName].Rows.Count);
        }

        [Test]
        public void 正しい日付にセットされているか()
        {
            MonthlyReport _mr = new MonthlyReport(2013, 1);
            _mr.setMonth(12);
            DataSet _ds = _mr.getMonthlyWorkReport();
            Assert.AreEqual("通常勤務", _ds.Tables[this.listTableName].Rows[13]["note"]);
        }

        [Test]
        public void 勤務合計時間のテスト()
        {
            MonthlyReport _mr = new MonthlyReport(2013, 1);
            // 正しい合計時間か
            _mr.setMonth(12);
            DataSet _ds = _mr.getMonthlyWorkReport();
            Assert.AreEqual("27 h", _mr.getTotalTimeText());
            // 合計が0
            _mr.setMonth(9);
            _ds = _mr.getMonthlyWorkReport();
            Assert.AreEqual("0 h", _mr.getTotalTimeText());
            // 異常系：SQLから取れない場合
            MonthlyReport _mr_err = new MonthlyReport(2013, -1);
            _mr_err.setMonth(12);
            _ds = _mr_err.getMonthlyWorkReport();
            Assert.AreEqual("0 h", _mr.getTotalTimeText());
        }

        [Test]
        public void 超過勤務合計時間のテスト()
        {
            MonthlyReport _mr = new MonthlyReport(2013, 1);
            // 正しい合計時間か
            _mr.setMonth(12);
            DataSet _ds = _mr.getMonthlyWorkReport();
            Assert.AreEqual("5 h", _mr.getTotalOverTime125Text());
            // 合計が0
            _mr.setMonth(9);
            _ds = _mr.getMonthlyWorkReport();
            Assert.AreEqual("0 h", _mr.getTotalOverTime125Text());
            // 異常系：SQLから取れない場合
            MonthlyReport _mr_err = new MonthlyReport(2013, -1);
            _mr_err.setMonth(12);
            _ds = _mr_err.getMonthlyWorkReport();
            Assert.AreEqual("0 h", _mr.getTotalOverTime125Text());
        }

        [Test]
        public void 深夜勤務合計時間のテスト()
        {
            MonthlyReport _mr = new MonthlyReport(2013, 1);
            // 正しい合計時間か
            _mr.setMonth(12);
            DataSet _ds = _mr.getMonthlyWorkReport();
            Assert.AreEqual("0 h", _mr.getTotalOverTime150Text());
            // 合計が0
            _mr.setMonth(9);
            _ds = _mr.getMonthlyWorkReport();
            Assert.AreEqual("0 h", _mr.getTotalOverTime150Text());
            // 異常系：SQLから取れない場合
            MonthlyReport _mr_err = new MonthlyReport(2013, -1);
            _mr_err.setMonth(12);
            _ds = _mr_err.getMonthlyWorkReport();
            Assert.AreEqual("0 h", _mr.getTotalOverTime150Text());
        }

    }
}
