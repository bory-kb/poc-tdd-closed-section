using NUnit.Framework;
using poc_tdd_closed_section;

namespace poc_tdd_closed_setction_test
{
    public class ���[�_�Ə�[�_���󂯎�萮����Ԃ�Ԃ�ClosedSection�N���X
    {
        [SetUp]
        public void �O����()
        {
        }

        [Test]
        public void ���[�_��3��[�_��7�̂Ƃ�3�J���}7�Ƃ��ĕԂ�()
        {
            var ret = ClosedSection.ReturnClosedSection(3, 7);
            Assert.AreEqual("[3,7]", ret);
        }

        [Test]
        public void ���[�_��4��[�_��8�̂Ƃ�4�J���}8�Ƃ��ĕԂ�()
        {
            var ret = ClosedSection.ReturnClosedSection(4, 8);
            Assert.AreEqual("[4,8]", ret);
        }

        [Test]
        public void ���[�_3�Ə�[�_7���󂯎��ClosedSection�N���X���C���X�^���X�������()
        {
            var ret = new ClosedSection(3,7);
            Assert.AreEqual("[3,7]", $"[{ret._lower},{ret._upper}]");
        }
    }
}