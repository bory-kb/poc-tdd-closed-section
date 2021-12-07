using NUnit.Framework;
using poc_tdd_closed_section;

namespace poc_tdd_closed_setction_test
{
    public class 下端点と上端点を受け取り整数閉区間を返すClosedSectionクラス
    {
        [SetUp]
        public void 前準備()
        {
        }

        [Test]
        public void 下端点が3上端点が7のとき3カンマ7として返す()
        {
            var ret = ClosedSection.ReturnClosedSection(3, 7);
            Assert.AreEqual("[3,7]", ret);
        }

        [Test]
        public void 下端点が4上端点が8のとき4カンマ8として返す()
        {
            var ret = ClosedSection.ReturnClosedSection(4, 8);
            Assert.AreEqual("[4,8]", ret);
        }

        [Test]
        public void 下端点3と上端点7を受け取りClosedSectionクラスがインスタンス化される()
        {
            var ret = new ClosedSection(3,7);
            Assert.AreEqual("[3,7]", $"[{ret._lower},{ret._upper}]");
        }
    }
}