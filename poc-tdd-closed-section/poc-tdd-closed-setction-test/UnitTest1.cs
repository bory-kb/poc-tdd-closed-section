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
        public void 下端点3と上端点7を受け取りClosedSectionクラスがインスタンス化される()
        {
            ClosedSection ret = new ClosedSection(3, 7);
            Assert.AreEqual("[3,7]", $"[{ret._lower},{ret._upper}]");
        }

        [Test]
        public void 下端点が3上端点が7のとき3カンマ7として返す()
        {
            var instance = new ClosedSection(3, 7);
            var ret = instance.ReturnClosedSection();
            Assert.AreEqual("[3,7]", ret);
        }

        [Test, nameof("tetetetetetetetete")]
        public void 下端点が4上端点が8のとき4カンマ8として返す()
        {
            var instance = new ClosedSection(4, 8);
            var ret = instance.ReturnClosedSection();

            Assert.AreEqual("[4,8]", ret);
        }

    }
}