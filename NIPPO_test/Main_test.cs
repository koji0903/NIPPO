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
    class Main_test
    {

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
            Main _mo = new Main(1);
            Assert.AreEqual("肥後 太郎(開発部)", _mo.getUserName());
            // sectionが取れない場合
            _mo = new Main(6);
            Assert.AreEqual("lastname_value firstname_value()", _mo.getUserName());
        }
    }
}
