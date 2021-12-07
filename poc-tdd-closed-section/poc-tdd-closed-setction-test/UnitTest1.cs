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
        public void ���[�_3�Ə�[�_7���󂯎��ClosedSection�N���X���C���X�^���X�������()
        {
            ClosedSection ret = new ClosedSection(3, 7);
            Assert.AreEqual("[3,7]", $"[{ret._lower},{ret._upper}]");
        }

        [Test]
        public void ���[�_��3��[�_��7�̂Ƃ�3�J���}7�Ƃ��ĕԂ�()
        {
            var instance = new ClosedSection(3, 7);
            var ret = instance.ReturnClosedSection();
            Assert.AreEqual("[3,7]", ret);
        }

        [Test, nameof("tetetetetetetetete")]
        public void ���[�_��4��[�_��8�̂Ƃ�4�J���}8�Ƃ��ĕԂ�()
        {
            var instance = new ClosedSection(4, 8);
            var ret = instance.ReturnClosedSection();

            Assert.AreEqual("[4,8]", ret);
        }

    }
}