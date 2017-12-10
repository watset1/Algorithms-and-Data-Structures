using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PermutationPractical;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PermutationAlgorithmTest()
        {
            PermutationAlgorithm pa = new PermutationAlgorithm(0, 3);
            List<String> expected = new List<String>(new String[] { "111", "112", "113", "121", "122", "123", "131", "132", "133", "211", "212", "213", "221", "222", "223", "231", "232", "233", "311", "312", "313", "321", "322", "323", "331", "332", "333" });
            List<String> actual = pa.intToStringArray;
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
