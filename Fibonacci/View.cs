using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    class View
    {
        private void PrintInstructions()
        {
            Console.WriteLine("Fibonacci number search parameters");
            Console.WriteLine("1. By lenght: <number>");
            Console.WriteLine("2. By range of numbers: <start of range number> <end of range number>");
        }
        public byte ChoosePath()
        {
            bool check = true;
            byte answer = 1;
            while (check)
            {
                PrintInstructions();
                try
                {
                    answer = byte.Parse(Console.ReadLine());
                    if (answer < 0 || answer > 2)
                    {
                        throw new Exception("You can enter only 1 or 2, try again.");
                    }
                    check = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return answer;
        }
        public uint FibonacciLength()
        {
            uint length = 1;
            bool check = true;

            while (check)
            {
                Console.WriteLine("Enter: <number>");
                length = uint.Parse(Console.ReadLine());

                try
                {
                    if (length > uint.MaxValue || length == 0)
                    {
                        throw new Exception($"You can only enter a number in the range[1;{uint.MaxValue}]");
                    }
                    check = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return length;
        }
        public uint[] FibonacciRange()
        {
            bool check = true;
            uint startNumber = 1;
            uint endNumber = 1;
            uint[] numbers = new uint[2];
            while (check)
            {
                Console.WriteLine("Enter: <start of range number> <end of range number>");
                string[] parameters = Console.ReadLine().Split(' ');
                try
                {
                    if ((!uint.TryParse(parameters[0], out startNumber)) || startNumber == 0)
                    {
                        throw new Exception($"You can only enter a number in the range [1;{uint.MaxValue}]");
                    }
                    if ((!uint.TryParse(parameters[1], out endNumber)) || endNumber == 0)
                    {
                        throw new Exception($"You can only enter a number in the range [1;{uint.MaxValue}]");
                    }
                    if (endNumber <= startNumber)
                    {
                        throw new Exception($"<end of range number> should be more than <start of range number>");
                    }
                    check = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            numbers[0] = startNumber;
            numbers[1] = endNumber;
            return numbers;
        }
    }
}
