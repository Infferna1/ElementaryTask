using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyTicket
{
    class LuckyTicket
    {
        private int Min;
        private int Max;

        public LuckyTicket(string min, string max)
        {
            Min = int.Parse(min);
            Max = int.Parse(max);
        }

        private int[] ArrayOfNumber(int number)
        {
            int[] num = new int[6];
            num[0] = (number / 100000) % 10;
            num[1] = (number / 10000) % 10;
            num[2] = (number / 1000) % 10;
            num[3] = (number / 100) % 10;
            num[4] = (number / 10) % 10;
            num[5] = number % 10;
            return num;
        }

        private bool SimpleMethodCheck(int number)
        {
            int[] num = ArrayOfNumber(number);
            return ((num[0] + num[1] + num[2]) == (num[3] + num[4] + num[5]));
        }
        private bool HardMethodCheck(int number)
        {
            int[] num = ArrayOfNumber(number);
            return ((num[0] + num[2] + num[4]) == (num[1] + num[3] + num[5]));
        }

        public byte QuantitySimpleMethod()
        {
            byte quantitySimpleMethod = 0;
            for (int i = Min; i <= Max; i++)
            {
                if (SimpleMethodCheck(i))
                {
                    quantitySimpleMethod++;
                }
            }
            return quantitySimpleMethod;
        }
        public byte QuantityHardMethod()
        {
            byte quantityHardMethod = 0;
            for (int i = Min; i <= Max; i++)
            {
                if (HardMethodCheck(i))
                {
                    quantityHardMethod++;
                }
            }
            return quantityHardMethod;
        }
    }
}
