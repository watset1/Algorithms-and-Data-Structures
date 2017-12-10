using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nQueensPractical;

namespace nQueensTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ChessBoardIsLegalNotLegalUpDiagonal()
        {
            ChessBoard cb = new ChessBoard(4);
            cb.AddQueen(0, 0);
            cb.AddQueen(3, 1);
            cb.AddQueen(2, 2);
            cb.AddQueen(1, 3);

            bool expected = false;
            bool actual = cb.IsLegal();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ChessBoardIsLegalNotLegalDownDiagonal()
        {
            ChessBoard cb = new ChessBoard(4);
            cb.AddQueen(0, 0);
            cb.AddQueen(1, 1);
            cb.AddQueen(2, 2);
            cb.AddQueen(0, 3);

            bool expected = false;
            bool actual = cb.IsLegal();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ChessBoardIsLegalNotLegalHorizontal()
        {
            ChessBoard cb = new ChessBoard(4);
            cb.AddQueen(3, 0);
            cb.AddQueen(0, 1);
            cb.AddQueen(2, 2);
            cb.AddQueen(0, 3);

            bool expected = false;
            bool actual = cb.IsLegal();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ChessBoardIsLegalIsLegal()
        {
            ChessBoard cb = new ChessBoard(4);
            cb.AddQueen(2, 0);
            cb.AddQueen(0, 1);
            cb.AddQueen(3, 2);
            cb.AddQueen(1, 3);

            bool expected = true;
            bool actual = cb.IsLegal();
            Assert.AreEqual(expected, actual);
        }
    }
}
