using System;

namespace FileParser
{
    class Program
    {
        static byte ChooseOption()
        {//Валидация
            Console.WriteLine("Choose option:\n1 - How often does the string occur\n2 - Replace the string with the specified one");
            byte option = byte.Parse(Console.ReadLine());
            return option;
        }
        static string ChoosePathToFile()
        {//Валидация
            Console.Write("Enter path to file\n");
            Console.WriteLine("(Example: C:\\user\\User\\file1.txt)");
            string pathToFile = Console.ReadLine();
            return pathToFile;
        }
        static string ChooseLineToCount()
        {//Валидация
            Console.WriteLine("Enter the line to find: ");
            string lineToCount = Console.ReadLine();
            return lineToCount;
        }

        static void Main(string[] args)
        {
            FileParser fileParser = new FileParser(ChooseOption(), ChoosePathToFile(), ChooseLineToCount());
            fileParser.OptionController();
        }
    }
}
