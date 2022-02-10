using DAY_13_Generics;
using NUnit.Framework;

namespace DAY_13_GenericTest
{
    public class Tests
    {
        MaxNUmberCheck max = new MaxNUmberCheck();
        [Test]
        public void ReturnMaxNumberForFirstPosition()
        {
            int maxNum = max.IntMax(30, 20, 10);
            Assert.AreEqual(3, maxNum);
        }

        [Test]
        public void ReturnMaxNumberForSecondPosition()
        {
            int maxNum = max.IntMax(20, 30, 10);
            Assert.AreEqual(3, maxNum);
        }

        [Test]
        public void ReturnMaxNumberForThirdPosition()
        {
            int maxNum = max.IntMax(20, 10, 30);
            Assert.AreEqual(3, maxNum);
        }
    }
}