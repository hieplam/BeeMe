using System.Collections.Generic;
using NUnit.Framework;
using SeeMe.Utilitiis;

namespace SeeMe.Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            
            list.Shuffle();

            Assert.Equals(1, 1);

        }
    }
}
