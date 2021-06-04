using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyTicket
{
    class View
    {

        public string GetMinTicket()
        {
            Console.WriteLine("Enter MIN number of ticket:");//validation
            string min = Console.ReadLine();
            return min;
        }
        public string GetMaxTicket()
        {
            Console.WriteLine("Enter MAX number of ticket:");//validation
            string max = Console.ReadLine();
            return max;
        }

        public void PrintResult(byte quantitySimpleMethod, byte quantityHardMethod)
        {
            if (quantitySimpleMethod > quantityHardMethod)
            {
                Console.WriteLine("The easy method won");
            }
            else if (quantitySimpleMethod < quantityHardMethod)
            {
                Console.WriteLine("The hard method won");
            }
            else
            {
                Console.WriteLine("Both are good");
            }

            Console.WriteLine($"Easy method  : {quantitySimpleMethod}");
            Console.WriteLine($"Hard method : {quantityHardMethod}");
        }
    }
}
