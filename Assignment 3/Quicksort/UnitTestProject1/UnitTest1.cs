using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quicksort;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void QuickSortTest()
        {
            int[] intArray = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Sort.QuickSort(intArray, 0, intArray.Length - 1);
            CollectionAssert.AreEqual(expected, intArray);
        }

        [TestMethod]
        public void QuickSortDuplicateTest()
        {
            int[] intArray = { 2, 8, 7, 4, 2, 1, 9, 6, 4 };
            int[] expected = { 1, 2, 2, 4, 4, 6, 7, 8, 9 };
            Sort.QuickSort(intArray, 0, intArray.Length - 1);
            CollectionAssert.AreEqual(expected, intArray);
        }
    }
}
