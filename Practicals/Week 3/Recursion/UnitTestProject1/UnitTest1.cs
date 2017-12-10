using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recursion;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReverseItTest()
        {
            RecursionMachine rm = new RecursionMachine();
            String expected = "edcba";
            String actual = rm.ReverseIt("abcde");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumToNTest()
        {
            RecursionMachine rm = new RecursionMachine();
            int expected = 1 + 2 + 3 + 4 + 5 + 6;
            int actual = rm.SumToN(6);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PalindromeIsPalindromeEvenLetters()
        {
            RecursionMachine rm = new RecursionMachine();
            bool expected = true;
            bool actual = rm.Palindrome("aabbaa");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PalindromeIsPalindromeOddLetters()
        {
            RecursionMachine rm = new RecursionMachine();
            bool expected = true;
            bool actual = rm.Palindrome("aabaa");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PalindromeIsNotPalindromeEvenLetters()
        {
            RecursionMachine rm = new RecursionMachine();
            bool expected = false;
            bool actual = rm.Palindrome("aabdaa");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PalindromeIsNotPalindromeOddLetters()
        {
            RecursionMachine rm = new RecursionMachine();
            bool expected = false;
            bool actual = rm.Palindrome("aabbcaa");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveItTest()
        {
            RecursionMachine rm = new RecursionMachine();
            String expected = "Emerson";
            String actual = rm.RemoveIt("x", "xExmxexxxxxrxsxoxnx");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeSortAllDifferentValues()
        {
            int[] unmergedArray = { 2, 1, 7, 3, 8, 5, 6, 4 };
            RecursionMachine rm = new RecursionMachine();
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            rm.MergeSort(unmergedArray, 0, unmergedArray.Length);
            int[] actual = unmergedArray;
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeSortDuplicateItems()
        {
            int[] unmergedArray = { 2, 1, 7, 3, 5, 5, 6, 4 };
            RecursionMachine rm = new RecursionMachine();
            int[] expected = { 1, 2, 3, 4, 5, 5, 6, 7 };
            rm.MergeSort(unmergedArray, 0, unmergedArray.Length);
            int[] actual = unmergedArray;
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BinarySearchTargetExistsEvenNumberOfValues()
        {
            int[] sortedArray = { 1, 3, 9, 18, 23, 27, 37, 58, 62, 74, 76, 78 };
            RecursionMachine rm = new RecursionMachine();
            bool expected = true;
            bool actual = rm.BinarySearch(sortedArray, 3, 0, sortedArray.Length);
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BinarySearchTargetDoesntExistEvenNumberOfValues()
        {
            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            RecursionMachine rm = new RecursionMachine();
            bool expected = false;
            bool actual = rm.BinarySearch(sortedArray, 9, 0, sortedArray.Length);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BinarySearchTargetDoesExistOddNumberOfValues()
        {
            int[] sortedArray = { 1, 3, 9, 18, 23, 27, 37, 58, 62, 74, 76, 78, 112 };
            RecursionMachine rm = new RecursionMachine();
            bool expected = true;
            bool actual = rm.BinarySearch(sortedArray, 9, 0, sortedArray.Length);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BinarySearchTargetDoesntExistOddNumberOfValues()
        {
            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            RecursionMachine rm = new RecursionMachine();
            bool expected = false;
            bool actual = rm.BinarySearch(sortedArray, 10, 0, sortedArray.Length);

            Assert.AreEqual(expected, actual);
        }
    }
}
