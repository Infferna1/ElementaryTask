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
        public void ViewArguments(string[] args)
        {
            foreach (var arg in args)
            {
                switch (arg)
                {
                    case "-help":
                        DisplayHelp();
                        break;
                    case "-task":
                        DisplayTask();
                        break;
                    default:
                        Console.WriteLine("The specified argument does not exist. To see a list of arguments, enter -help.");
                        break;
                }
            }
        }
        public void DisplayHelp()
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("Possible arguments:\n -help - Information about possible arguments\n -task - Information about task");

        }
        public void DisplayTask()
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("User can enter 2 parameters:\n<positive integer number>, \n<positive integer number>\n both parameters must be greater than zero");
            Console.WriteLine("========================================================");
            Console.WriteLine("User can enter data in the form: <length of sequence>\n <minimal square>");

        }
        public void PrintSequence(NumberSequence output)
        {
            Console.WriteLine(output);
        }
    }
}
