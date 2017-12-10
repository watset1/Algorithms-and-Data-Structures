using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordLadderApplication;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OneDifferenceTestTrue()
        {
            List<String> dictionary = new List<String>();
            dictionary.Add("laugh");
            dictionary.Add("lunge");
            dictionary.Add("gunge");
            WordLadder wl = new WordLadder();
            bool expected = true;
            bool actual = wl.OneLetterDifference("lunge", "gunge");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneDifferenceTestFalse()
        {
            List<String> dictionary = new List<String>();
            dictionary.Add("laugh");
            dictionary.Add("lunge");
            dictionary.Add("gunge");
            WordLadder wl = new WordLadder();
            bool expected = false;
            bool actual = wl.OneLetterDifference("lunge", "laugh");
            Assert.AreEqual(expected, actual);
        }
    }
}
