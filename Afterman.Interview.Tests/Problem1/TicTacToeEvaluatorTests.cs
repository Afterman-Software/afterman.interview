using Afterman.Interview.Problem1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Afterman.Interview.Tests.Problem1
{
    using Piece = TicTacToeBoard.TicTacToePiece;

    [TestClass]
    public class TicTacToeEvaluatorTests
    {
        // NOTE:  tests are not exhaustive for all valid board permutations

        [TestMethod]
        public void Row0WinTest()
        {
            // arrange
            TicTacToeBoard board = new TicTacToeBoard(
                Piece.X, Piece.X, Piece.X,
                Piece.X, Piece.O, Piece.O,
                Piece.O, Piece.X, Piece.X);

            // act
            Piece winner = TicTacToeEvaluator.EvaluateForWinner(board);

            // assert
            Assert.AreEqual(Piece.X, winner);
        }

        [TestMethod]
        public void Col1WinTest()
        {
            // arrange
            TicTacToeBoard board = new TicTacToeBoard(
                Piece.X, Piece.O, Piece.X,
                Piece.X, Piece.O, Piece.O,
                Piece.O, Piece.O, Piece.X);

            // act
            Piece winner = TicTacToeEvaluator.EvaluateForWinner(board);

            // assert
            Assert.AreEqual(Piece.O, winner);
        }

        [TestMethod]
        public void DiagonalWinTest()
        {
            // arrange
            TicTacToeBoard board = new TicTacToeBoard(
                Piece.X, Piece.O, Piece.X,
                Piece.X, Piece.X, Piece.O,
                Piece.O, Piece.O, Piece.X);

            // act
            Piece winner = TicTacToeEvaluator.EvaluateForWinner(board);

            // assert
            Assert.AreEqual(Piece.X, winner);
        }

        [TestMethod]
        public void NoWinnerTest()
        {
            // arrange
            TicTacToeBoard board = new TicTacToeBoard(
                Piece.O, Piece.O, Piece.X,
                Piece.X, Piece.X, Piece.O,
                Piece.O, Piece.O, Piece.X);

            // act
            Piece winner = TicTacToeEvaluator.EvaluateForWinner(board);

            // assert
            Assert.AreEqual(Piece.None, winner);
        }
    }
}
