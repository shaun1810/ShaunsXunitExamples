using System;
using Xunit;
using Xbehave; 

namespace calculatorTest
{
    public class CalculatorTestMethods
    {
        [Fact]
        public void addTest()
        {
            var c = new calculator.Calculator();
            int answer = c.Add(5,3);
            Assert.Equal(8,answer);
        }

        [Fact]
        public void modTest()
        {
            int x = 5;
            int y = 2;
            var c = new calculator.Calculator();
            int answer = c.Mod(x,y);
            Assert.Equal(1,answer);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void isOddTheory(int value)
        {
            Assert.True(isOdd(value));
        }

        bool isOdd(int value)
        {
            return value % 2 == 1;
        }

    }
}
