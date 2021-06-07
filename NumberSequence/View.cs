using System;
using System.Collections.Generic;
using System.Text;

namespace NumberSequence
{
    class View
    {
        public uint GetLength()
        {
            bool check = true;
            uint length = 0;
            while (check)
            {
                Console.WriteLine("Enter length of number sequence:");
                try
                {
                    length = uint.Parse(Console.ReadLine());
                    check = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return length;
        }

        public uint GetSquare()
        {
            uint square = 0;
            bool check = true;
            while (check) 
            { 
            Console.WriteLine("Enter minimal square:");
                try
                {
                    square = uint.Parse(Console.ReadLine());
                    check = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return square;
        }

        public void PrintSequence(NumberSequence output)
        {
            Console.WriteLine(output);
        }
    }
}
