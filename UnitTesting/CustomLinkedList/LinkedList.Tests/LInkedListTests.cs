namespace LinkedList.Tests
{
    using System;
    using CustomLinkedList;
    using NUnit.Framework;

    [TestFixture]
    public class LInkedListTests
    {
        private const int InitialCount = 0;

        [Test]
        public void ConstructorShouldSetCountToZero()
        {
            DynamicList<int> list = new DynamicList<int>();

            Assert.That(list.Count, Is.EqualTo(InitialCount));
        }

        [Test]
        public void IndexOperatorShouldReturnValue()
        {
            DynamicList<int> list = new DynamicList<int>();
            list.Add(6);

            int element = list[0];

            Assert.That(element, Is.EqualTo(6));
        }

        [Test]
        public void IndexOperatorShouldSetValue()
        {
            DynamicList<int> list = new DynamicList<int>();
            list.Add(6);

            list[0] = 8;

            Assert.That(list[0], Is.EqualTo(8));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(int.MaxValue)]
        [TestCase(100)]
        public void IndexOperatorShouldThrowArgumentOutOfRangeExceptionWhenGettingInvalidIndex(int index)
        {
            DynamicList<int> list = new DynamicList<int>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }
            int returnValue = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => returnValue = list[index]);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(int.MaxValue)]
        [TestCase(100)]
        public void IndexOperatorShouldThrowArgumentOutOfRangeExceptionWhenSettingInvalidIndex(int index)
        {
            DynamicList<int> list = new DynamicList<int>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            Assert.Throws<ArgumentOutOfRangeException>(() => list[index] = 3);
        }
    }
}
