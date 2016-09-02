namespace Afterman.Interview.Problem1
{
    public static class TicTacToeBoardExtensions
    {
        public static TicTacToeBoard.TicTacToePiece[] GetRow0(this TicTacToeBoard board)
        {
            TicTacToeBoard.TicTacToePiece[] results = new TicTacToeBoard.TicTacToePiece[3];
            results[0] = board.R0C0;
            results[1] = board.R0C1;
            results[2] = board.R0C2;
            return results;
        }

        public static TicTacToeBoard.TicTacToePiece[] GetRow1(this TicTacToeBoard board)
        {
            TicTacToeBoard.TicTacToePiece[] results = new TicTacToeBoard.TicTacToePiece[3];
            results[0] = board.R1C0;
            results[1] = board.R1C1;
            results[2] = board.R1C2;
            return results;
        }

        public static TicTacToeBoard.TicTacToePiece[] GetRow2(this TicTacToeBoard board)
        {
            TicTacToeBoard.TicTacToePiece[] results = new TicTacToeBoard.TicTacToePiece[3];
            results[0] = board.R2C0;
            results[1] = board.R2C1;
            results[2] = board.R2C2;
            return results;
        }

        public static TicTacToeBoard.TicTacToePiece[] GetCol0(this TicTacToeBoard board)
        {
            TicTacToeBoard.TicTacToePiece[] results = new TicTacToeBoard.TicTacToePiece[3];
            results[0] = board.R0C0;
            results[1] = board.R1C0;
            results[2] = board.R2C0;
            return results;
        }

        public static TicTacToeBoard.TicTacToePiece[] GetCol1(this TicTacToeBoard board)
        {
            TicTacToeBoard.TicTacToePiece[] results = new TicTacToeBoard.TicTacToePiece[3];
            results[0] = board.R0C1;
            results[1] = board.R1C1;
            results[2] = board.R2C1;
            return results;
        }

        public static TicTacToeBoard.TicTacToePiece[] GetCol2(this TicTacToeBoard board)
        {
            TicTacToeBoard.TicTacToePiece[] results = new TicTacToeBoard.TicTacToePiece[3];
            results[0] = board.R0C2;
            results[1] = board.R1C2;
            results[2] = board.R2C2;
            return results;
        }

        public static TicTacToeBoard.TicTacToePiece[] GetDiagonal0(this TicTacToeBoard board)
        {
            TicTacToeBoard.TicTacToePiece[] results = new TicTacToeBoard.TicTacToePiece[3];
            results[0] = board.R0C0;
            results[1] = board.R1C1;
            results[2] = board.R2C2;
            return results;
        }

        public static TicTacToeBoard.TicTacToePiece[] GetDiagonal1(this TicTacToeBoard board)
        {
            TicTacToeBoard.TicTacToePiece[] results = new TicTacToeBoard.TicTacToePiece[3];
            results[0] = board.R0C2;
            results[1] = board.R1C1;
            results[2] = board.R2C0;
            return results;
        }
    }
}
