using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    class Fibonacci
    {
        private uint Length;
        private uint StartNumber;
        private uint EndNumber;
        public Fibonacci(uint length)
        {
            Length = length;
        }
        public Fibonacci(uint[] numbers)
        {
            StartNumber = numbers[0];
            EndNumber = numbers[1];
        }
        public void ByLength()
        {
            uint j = 1;
            uint min, max;
            min = Convert.ToUInt32(Math.Pow(10, Length-1));
            max = Convert.ToUInt32(Math.Pow(10, Length));
            for (uint i = 1; i <= max; i += j)
            {
                if (i >= min)
                {
                    Console.Write(i + " ");
                }
                j = i - j;
            }
            Console.WriteLine();
        }
        public void ByRange()
        {
            uint j = 1;
            for (uint i = 1; i <= EndNumber; i += j)
            {
                if (i >= StartNumber)
                {
                    Console.Write(i + " ");
                }
                j = i - j;
            }
        }
    }
}
