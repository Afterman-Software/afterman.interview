using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afterman.Interview.Problem1
{
    
    public class TicTacToe
    {
        // Implement an algorithm designed to determine if there is a winner in a game of Tic-Tac-Toe
        // ==========================================================================================

        public enum PlayerNumEnum
        {
            PLAYER_ONE,
            PLAYER_TWO,
            PLAYER_MAX
        };

        public const string ArgumentOutOfRangeMessage = "Method inputs are out of range";

        // each player has a list of the rows in the game
        // a row score is incremented when the user places his token in that row
        private Dictionary<PlayerNumEnum, List<int>> RowScores = new Dictionary<PlayerNumEnum,List<int>>();

        // each player has a list of the columns in the game
        // a column score is incremented when the user places his token in that column
        private Dictionary<PlayerNumEnum, List<int>> ColScores = new Dictionary<PlayerNumEnum, List<int>>();

        // each player has a list of the two diagonals in the game
        // a diagonal score is incremented when the user places his token in that diagonal
        private Dictionary<PlayerNumEnum, List<int>> DiagScores = new Dictionary<PlayerNumEnum, List<int>>();

        private int dimensions = 3;

        // construct standard tic-tac-toe board size of 3x3
        public TicTacToe()
        {
            for (int pi = 0; pi < (int)PlayerNumEnum.PLAYER_MAX; pi++)
            {
                PlayerNumEnum p = (PlayerNumEnum)pi;
                this.RowScores[p] = new List<int>(new int[dimensions]);
                this.ColScores[p] = new List<int>(new int[dimensions]);
                this.DiagScores[p] = new List<int>(new int[2]);
            }
        }

        // construct non-standard tic-tac-toe sizes, greater than 3x3
        public TicTacToe(int dim)
        {
            this.dimensions = dim;
            for (int pi = 0; pi < (int)PlayerNumEnum.PLAYER_MAX; pi++)
            {
                PlayerNumEnum p = (PlayerNumEnum)pi;
                this.RowScores[p] = new List<int>(new int[dimensions]);
                this.ColScores[p] = new List<int>(new int[dimensions]);
                this.DiagScores[p] = new List<int>(new int[2]);
            }
        }

        // Set the position of the users token, but does not check if the space was already taken
        public void SetUserPosition(PlayerNumEnum player, int row, int col)
        {
            if (row < dimensions && col < dimensions && player < PlayerNumEnum.PLAYER_MAX)
            {
                RowScores[player][row]++;
                ColScores[player][col]++;
                if (row == col)
                {
                    DiagScores[player][0]++;
                }
                if (row + col == dimensions - 1)
                {
                    DiagScores[player][1]++;
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException(ArgumentOutOfRangeMessage);
            }
        }

        // Determines which player was the winner
        public PlayerNumEnum GetWinner()
        {
            PlayerNumEnum winner = PlayerNumEnum.PLAYER_MAX;
            for (int pi = 0; pi < (int)PlayerNumEnum.PLAYER_MAX; pi++)
            {
                PlayerNumEnum p = (PlayerNumEnum)pi;
                for (int index = 0; index < dimensions; index++ )
                {
                    if (RowScores[p][index] == dimensions
                        || ColScores[p][index] == dimensions)
                    {
                        return p;
                    }
                }
                if (DiagScores[p][0] == dimensions
                        || DiagScores[p][1] == dimensions)
                {
                    return p;
                }
            }

            return winner;
        }

        // Check whether a winner currently exists
        public bool WinnerExists()
        {
            return GetWinner() != PlayerNumEnum.PLAYER_MAX;
        }
    }
}
