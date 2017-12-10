using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithms;

namespace SortingAlgorithmsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void swapTest()
        {
            SortMachine sm = new SortMachine(2);
            sm.SortArray[0] = 4;
            sm.SortArray[1] = 2;
            sm.Swap(0, 1, 4, 2);
            int expected = 4;
            int actual = sm.SortArray[1];
            Assert.AreEqual(expected, actual);            
        }

        [TestMethod]
        public void BubbleSortTest()
        {
            SortMachine sm = new SortMachine(8);
            sm.SortArray[0] = 2;
            sm.SortArray[1] = 1;
            sm.SortArray[2] = 7;
            sm.SortArray[3] = 5;
            sm.SortArray[4] = 6;
            sm.SortArray[5] = 8;
            sm.SortArray[6] = 3;
            sm.SortArray[7] = 4;
            sm.BubbleSort();
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] actual = sm.SortArray;
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SelectionSortTest()
        {
            SortMachine sm = new SortMachine(8);
            sm.SortArray[0] = 4;
            sm.SortArray[1] = 2;
            sm.SortArray[2] = 7;
            sm.SortArray[3] = 5;
            sm.SortArray[4] = 6;
            sm.SortArray[5] = 8;
            sm.SortArray[6] = 3;
            sm.SortArray[7] = 1;
            sm.SelectionSort();
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] actual = sm.SortArray;
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            SortMachine sm = new SortMachine(8);
            sm.SortArray[0] = 4;
            sm.SortArray[1] = 2;
            sm.SortArray[2] = 7;
            sm.SortArray[3] = 5;
            sm.SortArray[4] = 6;
            sm.SortArray[5] = 8;
            sm.SortArray[6] = 3;
            sm.SortArray[7] = 1;
            sm.InsertionSort();
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] actual = sm.SortArray;
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeSortTest()
        {
            SortMachine sm = new SortMachine(8);
            sm.SortArray[0] = 4;
            sm.SortArray[1] = 2;
            sm.SortArray[2] = 7;
            sm.SortArray[3] = 5;
            sm.SortArray[4] = 6;
            sm.SortArray[5] = 8;
            sm.SortArray[6] = 3;
            sm.SortArray[7] = 1;
            sm.MergeSort();
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] actual = sm.SortArray;
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeArraySegmentsTest()
        {
            SortMachine sm = new SortMachine(8);
            sm.SortArray[0] = 2;
            sm.SortArray[1] = 7;
            sm.SortArray[2] = 4;
            sm.SortArray[3] = 5;
            sm.SortArray[4] = 6;
            sm.SortArray[5] = 8;
            sm.SortArray[6] = 3;
            sm.SortArray[7] = 1;
            sm.MergeArraySegments(sm.SortArray, 0, 1, 2, 3);
            int[] expected = { 2, 4, 5, 7, 6, 8, 3, 1 };
            int[] actual = sm.SortArray;
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
