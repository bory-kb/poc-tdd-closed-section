using NUnit.Framework;
using poc_tdd_closed_section;

namespace poc_tdd_closed_setction_test
{
    public class ���[�_�Ə�[�_���󂯎�萮����Ԃ�Ԃ�ClosedSection�N���X
    {
        public ClosedSection _closedSection;
        [SetUp]
        public void �O����()
        {
            _closedSection = new ClosedSection();
        }

        [Test]
        public void ���[�_��3��[�_��7�̂Ƃ�3�J���}7�Ƃ��ĕԂ�()
        {
            var ret = _closedSection.ReturnClosedSection(3, 7);
            Assert.AreEqual("[3,7]", ret);
        }

        [Test]
        public void ���[�_��4��[�_��8�̂Ƃ�4�J���}8�Ƃ��ĕԂ�()
        {
            var ret = _closedSection.ReturnClosedSection(4, 8);
            Assert.AreEqual("[4,8]", ret);
        }
    }
}