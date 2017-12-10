using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ADT_Tables;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DoubleHashCollisionTest()
        {
            HashTable hashTable = new HashTable(17);
            Node existingNode = new Node(7, "Start Node");           
            hashTable.InsertItem(existingNode, EHashType.doubleHash);
            int expected = 15;
            int actual = hashTable.HashCollision(7, 58, existingNode, EHashType.doubleHash);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void DoubleSetStepSizeTest()
        {
            HashTable hashTable = new HashTable(17);
            int expected = 8;
            int actual = hashTable.SetStepSize(58, EHashType.doubleHash);
            Assert.AreEqual(expected, actual);
        }
    }
}
