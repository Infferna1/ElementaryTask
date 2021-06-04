using System;
using System.Collections.Generic;
using System.Text;

namespace NumberSequence
{
    class View
    {
        public uint GetLength()
        {
            Console.WriteLine("Enter length of number sequence:");
            uint length = uint.Parse(Console.ReadLine());//validation
            return length;
        }
        public uint GetSquare()
        {
            Console.WriteLine("Enter minimal square:");
            uint square = uint.Parse(Console.ReadLine());//validation
            return square;
        }

        public void PrintSequence(NumberSequence output)
        {
            Console.WriteLine(output);
        }
    }
}
