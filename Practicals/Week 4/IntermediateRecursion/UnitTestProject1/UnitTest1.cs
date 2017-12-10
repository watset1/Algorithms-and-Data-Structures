using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntermediateRecursion;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PowerOfThreeTestIsTrue()
        {
            RecursionMachine rm = new RecursionMachine();
            bool expected = true;
            bool actual = rm.PowerOfThree(81);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PowerOfThreeTestIsFalse()
        {
            RecursionMachine rm = new RecursionMachine();
            bool expected = false;
            bool actual = rm.PowerOfThree(82);
            Assert.AreEqual(expected, actual);
        }
    }
}
