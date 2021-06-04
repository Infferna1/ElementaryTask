using System;
using System.Collections.Generic;
using System.Text;

namespace NumberToText
{
    class View
    {
        public string InputNumber()
        {
            Console.WriteLine("Enter number:");
            var number = Console.ReadLine();
            return number;
        }
    }
}
