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

        [TestFixture]
        class 下端点と上端点を受け取りClosedSectionクラスがインスタンス化される
        {

            [Test]
            public void 下端点3と上端点7を受け取りClosedSectionクラスがインスタンス化される()
            {
                ClosedSection actual = new ClosedSection(3, 7);
                Assert.IsInstanceOf<ClosedSection>(actual);
            }
        }


        [TestFixture]
        class 下端点の値が上端点の値より小さいとき下端点カンマ上端点の書式で返す
        {
            [Test]
            public void 下端点が3上端点が7のとき3カンマ7として返す()
            {
                var closedSection = new ClosedSection(3, 7);
                var actual = closedSection.ConvertToString();
                Assert.AreEqual("[3,7]", actual);
            }

            [Test]
            public void 下端点が4上端点が8のとき4カンマ8として返す()
            {
                var closedSection = new ClosedSection(4, 8);
                var actual = closedSection.ConvertToString();

                Assert.AreEqual("[4,8]", actual);
            }
        }



    }
}