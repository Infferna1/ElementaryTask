using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    class ChessBoard
    {
        public int Height { get; set; }
        public int Width { get; set; }
        
        public ChessBoard (/*int height, int width*/)
        {
            //Height = height;
            //Width = width;
        }

        public void Input()
        {
            Console.WriteLine("Enter height:");
            Height = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter width:");
            Width = int.Parse(Console.ReadLine());
        }

        public void Output()
        {
            for (int i = 0; i < Height; i++, Console.WriteLine())
                for (int j = 0; j < Width; j++)
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
