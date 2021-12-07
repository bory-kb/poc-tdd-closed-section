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

        [TestFixture]
        class ���[�_�Ə�[�_���󂯎��ClosedSection�N���X���C���X�^���X�������
        {

            [Test]
            public void ���[�_3�Ə�[�_7���󂯎��ClosedSection�N���X���C���X�^���X�������()
            {
                ClosedSection actual = new ClosedSection(3, 7);
                Assert.IsInstanceOf<ClosedSection>(actual);
            }
        }


        [TestFixture]
        class ���[�_�̒l����[�_�̒l��菬�����Ƃ����[�_�J���}��[�_�̏����ŕԂ�
        {
            [Test]
            public void ���[�_��3��[�_��7�̂Ƃ�3�J���}7�Ƃ��ĕԂ�()
            {
                var closedSection = new ClosedSection(3, 7);
                var actual = closedSection.ConvertToString();
                Assert.AreEqual("[3,7]", actual);
            }

            [Test]
            public void ���[�_��4��[�_��8�̂Ƃ�4�J���}8�Ƃ��ĕԂ�()
            {
                var closedSection = new ClosedSection(4, 8);
                var actual = closedSection.ConvertToString();

                Assert.AreEqual("[4,8]", actual);
            }
        }



    }
}