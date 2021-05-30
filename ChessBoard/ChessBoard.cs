using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    class ChessBoard
    {
        private byte Height;
        private byte Width;

        public ChessBoard(byte height, byte width)
        {
            Height = height;
            Width = width;
        }

        public void ChessBoardPrint()
        {
            for (byte i = 0; i < Height; i++, Console.WriteLine())
                for (byte j = 0; j < Width; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(" ");

                    }
                    else
                    {
                        Console.Write("*");

                    }
                }
            Console.ReadKey();
        }
    }
}
