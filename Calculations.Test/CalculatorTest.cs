namespace Calculations.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            //arrange

            var calculator = new Calculator();

            //act

            var res = calculator.Add(1,2);

            //assert
            Assert.Equal<int>(3,res);
        }
    }
}
