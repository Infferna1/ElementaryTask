using System;
using System.Text;
using Xunit;

namespace NumberSequence.Test
{
    public class NumberSequenceTests
    {
        [Fact]
        public void ToString_length0_emptyString()
        {
            uint[] parameters = new uint[2];
            parameters[0] = 0;
            parameters[1] = 5;
            NumberSequence numberSequence = new NumberSequence(parameters);
            string expected = "";
            numberSequence.Sequence();
            string actual = numberSequence.ToString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToString_square0_numberSequenceOfLength()
        {
            uint[] parameters = new uint[2];
            parameters[0] = 5;
            parameters[1] = 0;
            NumberSequence numberSequence = new NumberSequence(parameters);
            string expected = "1,2,3,4,5";
            numberSequence.Sequence();
            string actual = numberSequence.ToString();
            Assert.Equal(expected, actual);
        }

    }
}
