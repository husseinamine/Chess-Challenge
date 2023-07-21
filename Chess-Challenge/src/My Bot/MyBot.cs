using System.Collections.Generic;
using ChessChallenge.API;
using ChessChallenge.Application;

public class MyBot : IChessBot
{

    private Board board;
    private List<int> pieceValues = new List<int>(){ 1, 3, 3, 5, 9 };

    public Move Think(Board board, Timer timer)
    {
        this.board = board;
        Move[] moves = board.GetLegalMoves();

        foreach (Move move in moves)
        {

        }

        return moves[0];
    }

    private bool IsCheck(Move move)
    {
        board.MakeMove(move);
        bool isCheck = board.IsInCheck();
        board.UndoMove(move);

        return isCheck;
    }
}

enum PieceValue {
    Pawn   = 1,
    Knight = 3,
    Bishop = 4,
    Rook   = 5,
    Queen  = 9,
    King   = 999
}