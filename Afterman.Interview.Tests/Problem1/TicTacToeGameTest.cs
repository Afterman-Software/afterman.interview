using System;
using Afterman.Interview.Problem1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Afterman.Interview.Tests.Problem1
{
    [TestClass]
    public class TicTacToeGameTest
    {
        [TestMethod]
        public void TestColumnWins()
        {
            var ticTacToeGame = new TicTacToeGame( 3 );
            ticTacToeGame.BoardState[0, 0] = TicTacToeGame.MarkType.O;
            ticTacToeGame.BoardState[0, 1] = TicTacToeGame.MarkType.O;
            ticTacToeGame.BoardState[0, 2] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[1, 0] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[1, 1] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[1, 2] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[2, 0] = TicTacToeGame.MarkType.X;
            ticTacToeGame.BoardState[2, 1] = TicTacToeGame.MarkType.X;
            ticTacToeGame.BoardState[2, 2] = TicTacToeGame.MarkType.X;
            Assert.AreEqual( ticTacToeGame.CheckWinner(), TicTacToeGame.MarkType.X );

            ticTacToeGame.BoardState[0, 0] = TicTacToeGame.MarkType.O;
            ticTacToeGame.BoardState[0, 1] = TicTacToeGame.MarkType.X;
            ticTacToeGame.BoardState[0, 2] = TicTacToeGame.MarkType.O;
            ticTacToeGame.BoardState[1, 0] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[1, 1] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[1, 2] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[2, 0] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[2, 1] = TicTacToeGame.MarkType.X;
            ticTacToeGame.BoardState[2, 2] = TicTacToeGame.MarkType.X;

            Assert.AreEqual( ticTacToeGame.CheckWinner(), TicTacToeGame.MarkType.None );

            ticTacToeGame.BoardState[0, 0] = TicTacToeGame.MarkType.X;
            ticTacToeGame.BoardState[0, 1] = TicTacToeGame.MarkType.X;
            ticTacToeGame.BoardState[0, 2] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[1, 0] = TicTacToeGame.MarkType.O;
            ticTacToeGame.BoardState[1, 1] = TicTacToeGame.MarkType.O;
            ticTacToeGame.BoardState[1, 2] = TicTacToeGame.MarkType.O;
            ticTacToeGame.BoardState[2, 0] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[2, 1] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[2, 2] = TicTacToeGame.MarkType.None;

            Assert.AreEqual( ticTacToeGame.CheckWinner(), TicTacToeGame.MarkType.O );
        }

        [TestMethod]
        public void TestRowWins()
        {
            var ticTacToeGame = new TicTacToeGame( 3 );
            ticTacToeGame.BoardState[0, 0] = TicTacToeGame.MarkType.O;
            ticTacToeGame.BoardState[1, 0] = TicTacToeGame.MarkType.O;
            ticTacToeGame.BoardState[2, 0] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[0, 1] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[1, 1] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[2, 1] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[0, 2] = TicTacToeGame.MarkType.X;
            ticTacToeGame.BoardState[1, 2] = TicTacToeGame.MarkType.X;
            ticTacToeGame.BoardState[2, 2] = TicTacToeGame.MarkType.X;
            Assert.AreEqual( ticTacToeGame.CheckWinner(), TicTacToeGame.MarkType.X );
        }

        [TestMethod]
        public void TestDiagonalWins()
        {
            var ticTacToeGame = new TicTacToeGame( 3 );
            ticTacToeGame.BoardState[0, 0] = TicTacToeGame.MarkType.X;
            ticTacToeGame.BoardState[1, 0] = TicTacToeGame.MarkType.O;
            ticTacToeGame.BoardState[2, 0] = TicTacToeGame.MarkType.None;

            ticTacToeGame.BoardState[0, 1] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[1, 1] = TicTacToeGame.MarkType.X;
            ticTacToeGame.BoardState[2, 1] = TicTacToeGame.MarkType.None;

            ticTacToeGame.BoardState[0, 2] = TicTacToeGame.MarkType.O;
            ticTacToeGame.BoardState[1, 2] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[2, 2] = TicTacToeGame.MarkType.X;
            Assert.AreEqual( ticTacToeGame.CheckWinner(), TicTacToeGame.MarkType.X );
        }

        [TestMethod]
        public void TestReverseDiagonalWins()
        {
            var ticTacToeGame = new TicTacToeGame( 3 );
            ticTacToeGame.BoardState[0, 0] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[1, 0] = TicTacToeGame.MarkType.O;
            ticTacToeGame.BoardState[2, 0] = TicTacToeGame.MarkType.X;

            ticTacToeGame.BoardState[0, 1] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[1, 1] = TicTacToeGame.MarkType.X;
            ticTacToeGame.BoardState[2, 1] = TicTacToeGame.MarkType.None;

            ticTacToeGame.BoardState[0, 2] = TicTacToeGame.MarkType.X;
            ticTacToeGame.BoardState[1, 2] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[2, 2] = TicTacToeGame.MarkType.O;
            Assert.AreEqual( ticTacToeGame.CheckWinner(), TicTacToeGame.MarkType.X );
        }

        [TestMethod]
        public void TestReverseDiagonalNoWinner()
        {
            var ticTacToeGame = new TicTacToeGame( 3 );
            ticTacToeGame.BoardState[0, 0] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[1, 0] = TicTacToeGame.MarkType.O;
            ticTacToeGame.BoardState[2, 0] = TicTacToeGame.MarkType.X;

            ticTacToeGame.BoardState[0, 1] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[1, 1] = TicTacToeGame.MarkType.X;
            ticTacToeGame.BoardState[2, 1] = TicTacToeGame.MarkType.None;

            ticTacToeGame.BoardState[0, 2] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[1, 2] = TicTacToeGame.MarkType.None;
            ticTacToeGame.BoardState[2, 2] = TicTacToeGame.MarkType.O;
            Assert.AreEqual( ticTacToeGame.CheckWinner(), TicTacToeGame.MarkType.None );
        }


    }
}
