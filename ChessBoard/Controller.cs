using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    class Controller
    {
        private ChessBoard chessBoard;
        private View view;

        public void Start()
        {
            view = new View();
            chessBoard = new ChessBoard(view.InputHeight(), view.InputWidth());
            chessBoard.ChessBoardPrint();
        }
    }
}
