namespace Afterman.Interview.Problem1
{
    public class TicTacToeEvaluator
    {
        public static TicTacToeBoard.TicTacToePiece EvaluateForWinner(TicTacToeBoard board)
        {
            TicTacToeBoard.TicTacToePiece winner;

            if (HasWinner(board.GetRow0(), out winner))
                return winner;
            if (HasWinner(board.GetRow1(), out winner))
                return winner;
            if (HasWinner(board.GetRow2(), out winner))
                return winner;

            if (HasWinner(board.GetCol0(), out winner))
                return winner;
            if (HasWinner(board.GetCol1(), out winner))
                return winner;
            if (HasWinner(board.GetCol2(), out winner))
                return winner;

            if (HasWinner(board.GetDiagonal0(), out winner))
                return winner;
            if (HasWinner(board.GetDiagonal1(), out winner))
                return winner;

            return TicTacToeBoard.TicTacToePiece.None;
        }

        private static bool HasWinner(TicTacToeBoard.TicTacToePiece[] pieces, out TicTacToeBoard.TicTacToePiece winner)
        {
            // No array error handling or empty board check
            if(pieces[0] == pieces[1] && pieces[1] == pieces[2])
            {
                winner = pieces[0];
                return true;
            }

            winner = TicTacToeBoard.TicTacToePiece.None;
            return false;
        }
    }
}
