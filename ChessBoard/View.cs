using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    class View
    {
        public byte InputHeight()
        {
            Console.WriteLine("Enter height:");
            byte height = byte.Parse(Console.ReadLine());
            while ((height <= 0) || (height >= 51))
            {
                Console.WriteLine("Height must be bigger than 0 and lower than 51\nEnter height:");
                height = byte.Parse(Console.ReadLine());
            }
            return height;
        }

        public byte InputWidth()
        {
            Console.WriteLine("Enter width:");
            byte width = byte.Parse(Console.ReadLine());
            while ((width <= 0) || (width >= 51))
            {
                Console.WriteLine("Width must be bigger than 0 and lower than 51\nEnter width:");
                width = byte.Parse(Console.ReadLine());
            }
            return width;
        }
    }
}
