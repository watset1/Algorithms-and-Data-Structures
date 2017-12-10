using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vigenere;

namespace VigenereUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        VigenereController vigenere = new VigenereController();

        [TestMethod]
        public void moduloPositiveValue()
        {
            int expected = 2;
            int actual = vigenere.Modulo(28);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void moduloNegativeValue()
        {
            int expected = 19;
            int actual = vigenere.Modulo(-7);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void encryptOneLetterWraps()
        {
            char expected = 'A';
            char actual = vigenere.EncryptOneLetter('T', 'H');
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void encryptOneLetterNoWraps()
        {
            char expected = 'U';
            char actual = vigenere.EncryptOneLetter('T', 'B');
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void encryptOneLetterSpace()
        {
            char expected = ' ';
            char actual = vigenere.EncryptOneLetter(' ', 'B');
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void decryptOneLetterWraps()
        {
            char expected = 'T';
            char actual = vigenere.DecryptOneLetter('A', 'H');
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void decryptOneLetterNoWraps()
        {
            char expected = 'T';
            char actual = vigenere.DecryptOneLetter('U', 'B');
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void decryptOneLetterSpace()
        {
            char expected = ' ';
            char actual = vigenere.DecryptOneLetter(' ', 'B');
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void encryptWholeStringTest()
        {            
            String enteredString = "NEVER INSULT SEVEN MEN IF YOU ARE ONLY CARRYING A SIX SHOOTER";
            String key = "MORGAN";
            String expected = "ZSMKR VZGLRT FQJVT MRZ WW EOH MFV UNYK QRXRLUBX G SVJ GYUOGQF";
            String actual = vigenere.EncryptWholeString(enteredString, key);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void decryptWholeStringTest()
        {
            String enteredString = "ZSMKR VZGLRT FQJVT MRZ WW EOH MFV UNYK QRXRLUBX G SVJ GYUOGQF";
            String key = "MORGAN";
            String expected = "NEVER INSULT SEVEN MEN IF YOU ARE ONLY CARRYING A SIX SHOOTER";
            String actual = vigenere.DecryptWholeString(enteredString, key);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getOrdinalValueCapitalT()
        {
            int expected = 19;
            int actual = vigenere.GetOrdinalValue('T');
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void setCharacterValueNumber19()
        {
            char expected = 'T';
            char actual = vigenere.SetCharacterValue(19);
            Assert.AreEqual(expected, actual);
        }
    }
}
