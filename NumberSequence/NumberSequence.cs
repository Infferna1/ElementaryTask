using System;
using System.Collections.Generic;
using System.Text;

namespace NumberSequence
{
    class NumberSequence
    {
        private uint Length;
        private uint Square;
        private StringBuilder output;
        public NumberSequence(uint[] parameters)
        {
            Length = parameters[0];
            Square = parameters[1];
        }
        public override string ToString()
        {
            return output.ToString();
        }
        public void Sequence()
        {
            output = new StringBuilder();
            int i = 0;
            uint j = (uint)Math.Sqrt(Square)+1;
            while (i < Length)
            {
                if (Math.Pow(j, 2) > Square)
                {
                    if (i == Length - 1)
                    {
                        output.Append(j);
                    }
                    else { 
                    output.Append(j + ",");
                    }
                    i++;
                }
                j++;
            }
        }
    }
}
