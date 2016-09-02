namespace Afterman.Interview.Problem1
{
    /// <summary>
    /// Board for modeling Tic-Tac-Toe -- not for interactive play
    /// </summary>
    public class TicTacToeBoard
    {
        public enum TicTacToePiece
        {
            None,
            X,
            O
        }

        public TicTacToePiece R0C0 { get; private set; }
        public TicTacToePiece R0C1 { get; private set; }
        public TicTacToePiece R0C2 { get; private set; }

        public TicTacToePiece R1C0 { get; private set; }
        public TicTacToePiece R1C1 { get; private set; }
        public TicTacToePiece R1C2 { get; private set; }

        public TicTacToePiece R2C0 { get; private set; }
        public TicTacToePiece R2C1 { get; private set; }
        public TicTacToePiece R2C2 { get; private set; }

        public TicTacToeBoard(TicTacToePiece r0c0, TicTacToePiece r0c1, TicTacToePiece r0c2,
            TicTacToePiece r1c0, TicTacToePiece r1c1, TicTacToePiece r1c2,
            TicTacToePiece r2c0, TicTacToePiece r2c1, TicTacToePiece r2c2)
        {
            this.R0C0 = r0c0;
            this.R0C1 = r0c1;
            this.R0C2 = r0c2;

            this.R1C0 = r1c0;
            this.R1C1 = r1c1;
            this.R1C2 = r1c2;

            this.R2C0 = r2c0;
            this.R2C1 = r2c1;
            this.R2C2 = r2c2;
        }
    }
}
