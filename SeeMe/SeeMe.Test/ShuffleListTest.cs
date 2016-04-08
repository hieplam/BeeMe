using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SeeMe.Utilitiis;

namespace SeeMe.Test
{
    [TestFixture]
    public class ShuffleListTest
    {
        private List<int> IntList;

        [SetUp]
        public void Init()
        {
            IntList = new List<int>();
        }

        [Test]
        public void ListWithNoElement_NoException()
        {
            Assert.DoesNotThrow(() => { });

        }

        [Test]
        public void ListWithOneElement_SameOrder()
        {
            IntList.Add(1);
            var cloneList = Clone(IntList);

            IntList.Shuffle();

            Assert.AreEqual(IntList.First(),cloneList.First(),"Element must be the same");
        }

        [Test]
        public void SameElementAfterShuffle()
        {
            for (int i = 0; i < 10; i++)
            {
                IntList.Add(i);
            }

            IntList.Shuffle();

            Assert.AreEqual(IntList.Count, 10);
        }


        [Test]
        public void ListMoreThenTwoElement_NotSameOrder()
        {
            for (int i = 0; i < 10; i++)
            {
                IntList.Add(i);
            }
            var cloneList = Clone(IntList);

            IntList.Shuffle();

            Assert.AreNotEqual(IntList[0],cloneList[0]);
            Assert.AreNotEqual(IntList[1], cloneList[1]);
            Assert.AreNotEqual(IntList[2], cloneList[2]);
        }

        private List<T> Clone<T>(List<T> origin)
        {
            return origin.ToList();
        }

        [TearDown]
        public void Destroy()
        {
            IntList.Clear();
        }
    }
}
