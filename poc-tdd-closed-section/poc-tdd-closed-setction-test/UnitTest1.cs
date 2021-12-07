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
            var ret = ClosedSection.ReturnClosedSection();
            Assert.AreEqual("[3,7]",ret);
        }
    }
}