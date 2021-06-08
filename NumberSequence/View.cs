using System;
using System.Collections.Generic;
using System.Text;

namespace NumberSequence
{
    class View
    {
        public uint[] GetParameters()
        {
            uint[] parameters = new uint[2];
            bool check = true;
            uint length = 0;
            uint square = 0;
            while (check)
            {
                Console.WriteLine("Enter length of number sequence:");
                try
                {
                    length = uint.Parse(Console.ReadLine());
                    if (length <= 0)
                    {
                        throw new Exception("Enter length higher than 0");
                    }
                    check = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            check = true;
            while (check)
            {
                Console.WriteLine("Enter minimal square:");
                try
                {
                    square = uint.Parse(Console.ReadLine());
                    if (square <= 0)
                    {
                        throw new Exception("Enter square higher than 0");
                    }
                    check = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            parameters[0] = length;
            parameters[1] = square;
            return parameters;
        }

        public void PrintSequence(NumberSequence output)
        {
            Console.WriteLine(output);
        }
    }
}
