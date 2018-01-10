namespace calculatorTest
{
    using Xbehave;
    using Xunit;
    public class CalculatorFeatures
    {
        [Scenario]
        public void addition(int x, int y, calculator.Calculator calc, int answer)
        {
            //parameters of doom
            "Given number 1"
            .x(() => x=1);

            "And the number 2"
            .x(() => y =2);

            "And a calculator object"
            .x(() => calc = new calculator.Calculator());

            "When x and Y are added together"
            .x(()=> answer = calc.Add(x,y));

            "The answer is 3"
            .x(() => Assert.Equal(3, answer));
        }
    }
}