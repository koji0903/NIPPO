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
    public class testCalc_test
    {
        // 追加：ここにイチからテストを書く
        [Test]
        public void CUIでのテスト()
        {
            testCalc calc = new testCalc();
            int result = calc.Add(1, 2);
            Assert.AreEqual(3, result);
        }
    }
}
