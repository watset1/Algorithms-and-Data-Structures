using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearDataStructures;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsBalancedCorrectBrackets()
        {
            String inputString = "ab{cde}fg";
            AlgorithmMachine am = new AlgorithmMachine();
            bool expected = true;
            bool actual = am.IsBalanced(inputString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsBalancedIncorrectNumberOfBrackets()
        {
            String inputString = "ab{cde}fg}";
            AlgorithmMachine am = new AlgorithmMachine();
            bool expected = false;
            bool actual = am.IsBalanced(inputString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsBalancedIncorrectOrder()
        {
            String inputString = "ab}cde{fg";
            AlgorithmMachine am = new AlgorithmMachine();
            bool expected = false;
            bool actual = am.IsBalanced(inputString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PostfixParserTest()
        {
            String inputString = "234*+5+";
            AlgorithmMachine am = new AlgorithmMachine();
            int expected = 19;
            int actual = am.PostfixParser(inputString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringQueuePopOrder()
        {
            StringQueue queue = new StringQueue();
            queue.Push("a");
            queue.Push("b");
            queue.Push("c");
            string expected1 = "a";
            string expected2 = "b";
            string expected3 = "c";
            string actual1 = queue.Pop();
            string actual2 = queue.Pop();
            string actual3 = queue.Pop();
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [TestMethod]
        public void IsPalindromeCorrect()
        {
            String inputString = "abbcbba";
            AlgorithmMachine am = new AlgorithmMachine();
            bool expected = true;
            bool actual = am.IsPalindrome(inputString);
            Assert.AreEqual(expected, actual);
        }
    }
}
