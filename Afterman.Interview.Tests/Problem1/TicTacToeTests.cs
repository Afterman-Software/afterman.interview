using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Afterman.Interview.Problem1;

namespace Afterman.Interview.Tests.Problem1
{
    [TestClass]
    public class TicTacToeTests
    {

        [TestMethod]
        public void TestColumnWins()
        {
            for (int col = 0; col < 3; col++)
            {
                TicTacToe game = new TicTacToe();
                for (int i = 0; i < 3; i++)
                {
                    Assert.IsFalse(game.WinnerExists());
                    game.SetUserPosition(TicTacToe.PlayerNumEnum.PLAYER_ONE, i, col);
                }
                Assert.IsTrue(game.WinnerExists());
                Assert.AreEqual(TicTacToe.PlayerNumEnum.PLAYER_ONE, game.GetWinner());
            }
        }

        [TestMethod]
        public void TestRowWins()
        {
            for (int row = 0; row < 3; row++)
            {
                TicTacToe game = new TicTacToe();
                for (int i = 0; i < 3; i++)
                {
                    Assert.IsFalse(game.WinnerExists());
                    game.SetUserPosition(TicTacToe.PlayerNumEnum.PLAYER_ONE, row, i);
                }
                Assert.IsTrue(game.WinnerExists());
                Assert.AreEqual(TicTacToe.PlayerNumEnum.PLAYER_ONE, game.GetWinner());
            }
        }

        [TestMethod]
        public void TestDiagonalWins()
        {
            // check backward slash
            {
                TicTacToe game = new TicTacToe();
                for (int row = 0; row < 3; row++)
                {
                    Assert.IsFalse(game.WinnerExists());
                    game.SetUserPosition(TicTacToe.PlayerNumEnum.PLAYER_ONE, row, row);
                }
                Assert.IsTrue(game.WinnerExists());
                Assert.AreEqual(TicTacToe.PlayerNumEnum.PLAYER_ONE, game.GetWinner());
            }
            // check forward slash
            {
                TicTacToe game = new TicTacToe();
                for (int row = 0; row < 3; row++)
                {
                    Assert.IsFalse(game.WinnerExists());
                    game.SetUserPosition(TicTacToe.PlayerNumEnum.PLAYER_ONE, row, 2 - row);
                }
                Assert.IsTrue(game.WinnerExists());
                Assert.AreEqual(TicTacToe.PlayerNumEnum.PLAYER_ONE, game.GetWinner());
            }
        }

        [TestMethod]
        public void TestPlayerWins()
        {
            for (int player = 0; player < 2; player++)
            {
                TicTacToe.PlayerNumEnum winner = (TicTacToe.PlayerNumEnum)player;
                TicTacToe game = new TicTacToe();
                for (int i = 0; i < 3; i++)
                {
                    Assert.IsFalse(game.WinnerExists());
                    game.SetUserPosition(winner, 0, i);
                }
                Assert.IsTrue(game.WinnerExists());
                Assert.AreEqual(winner, game.GetWinner());
            }
        }


        [TestMethod]
        public void TestOutOfBounds()
        {
           TicTacToe.PlayerNumEnum player = TicTacToe.PlayerNumEnum.PLAYER_MAX;
           TicTacToe game = new TicTacToe();
           try
           {
               game.SetUserPosition(player, 0, 0);
           }
           catch (ArgumentOutOfRangeException ex)
           {
               StringAssert.Contains(ex.Message, TicTacToe.ArgumentOutOfRangeMessage);
           }
           player = TicTacToe.PlayerNumEnum.PLAYER_ONE;
           try
           {
               game.SetUserPosition(player, 0, 5);
           }
           catch (ArgumentOutOfRangeException ex)
           {
               StringAssert.Contains(ex.Message, TicTacToe.ArgumentOutOfRangeMessage);
           }
           try
           {
               game.SetUserPosition(player, 5, 0);
           }
           catch (ArgumentOutOfRangeException ex)
           {
               StringAssert.Contains(ex.Message, TicTacToe.ArgumentOutOfRangeMessage);
           }
        }

        [TestMethod]
        public void TestAlternateSizes()
        {
            for (int dim = 3; dim < 10; dim++)
            {
                // check backward slash
                {
                    TicTacToe game = new TicTacToe(dim);
                    for (int row = 0; row < dim; row++)
                    {
                        Assert.IsFalse(game.WinnerExists());
                        game.SetUserPosition(TicTacToe.PlayerNumEnum.PLAYER_ONE, row, row);
                    }
                    Assert.IsTrue(game.WinnerExists());
                    Assert.AreEqual(TicTacToe.PlayerNumEnum.PLAYER_ONE, game.GetWinner());
                }
                // check forward slash
                {
                    TicTacToe game = new TicTacToe(dim);
                    for (int row = 0; row < dim; row++)
                    {
                        Assert.IsFalse(game.WinnerExists());
                        game.SetUserPosition(TicTacToe.PlayerNumEnum.PLAYER_ONE, row, (dim - 1) - row);
                    }
                    Assert.IsTrue(game.WinnerExists());
                    Assert.AreEqual(TicTacToe.PlayerNumEnum.PLAYER_ONE, game.GetWinner());
                }
            }
        }

    }
}
