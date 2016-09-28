using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afterman.Interview.Problem1
{
    public class TicTacToeGame
    {
        public TicTacToeGame( int boardSize = 3 )
        {
            this.BoardSize = boardSize;
            this.BoardState = new MarkType[boardSize, boardSize];
        }

        private int BoardSize;

        public enum MarkType { None, X, O };

        public MarkType[,] BoardState;

        // adapted from http://stackoverflow.com/a/9746758/1755417
        public MarkType CheckWinner()
        {
            foreach ( MarkType markType in new MarkType[2] { MarkType.O, MarkType.X } )
            {
                int row = 0;
                int col = 0;
                int i = 0;

                // Check for rows of consecutive marks
                for ( row = 0; row < this.BoardSize; row++ )
                {
                    // And all columns until the end
                    for ( col = 0; col < ( this.BoardSize - ( this.BoardSize - 1 ) ); col++ )
                    {
                        // For consecutive rows of the current player's mark
                        while ( BoardState[row, col] == markType )
                        {
                            col++;
                            i++;
                            if ( i == this.BoardSize )
                            {
                                return markType;
                            }
                        }

                        i = 0;
                    }
                }

                // Check for columns of consecutive marks
                for ( col = 0; col < this.BoardSize; col++ )
                {
                    for ( row = 0; row < ( this.BoardSize - ( this.BoardSize - 1 ) ); row++ )
                    {
                        while ( BoardState[row, col] == markType )
                        {
                            row++;
                            i++;
                            if ( i == this.BoardSize )
                            {
                                return markType;
                            }
                        }

                        i = 0;
                    }
                }

                // Check for forward diags of consecutive marks
                for ( col = 0; col < ( this.BoardSize - ( this.BoardSize - 1 ) ); col++ )
                {
                    for ( row = 0; row < ( this.BoardSize - ( this.BoardSize - 1 ) ); row++ )
                    {
                        while ( BoardState[row, col] == markType )
                        {
                            // Go down a row
                            row++;
                            
                            // And over a column
                            col++;
                            i++;
                            if ( i == this.BoardSize )
                            {
                                return markType;
                            }
                        }

                        i = 0;
                    }
                }

                // Check for backward diags of consecutive marks
                // Start from the last column and go until N columns from the first
                for ( col = this.BoardSize - 1; col > 0 + ( this.BoardSize - 2 ); col-- )
                {
                    for ( row = 0; row < ( this.BoardSize - ( this.BoardSize - 1 ) ); row++ )
                    {
                        while ( BoardState[row, col] == markType )
                        {
                            // Go down a row
                            row++;

                            // And back a column
                            col--;

                            i++;
                            if ( i == this.BoardSize )
                            {
                                return markType;
                            }
                        }

                        i = 0;
                    }
                }
            }

            return MarkType.None;
        }
    }
}
