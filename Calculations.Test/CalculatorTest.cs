namespace Calculations.Test
{
    public class CalculatorTest
    {
        [Fact]
        [Trait("Owner","Daniel")]
        [Trait("Category","Calculator")]
        public void Add_Given1And2_Return3()
        {
            //arrange
            var calculator = new Calculator();

            //act
            var res = calculator.Add(1,2);

            //assert
            Assert.Equal<int>(3,res);
        }

        [Fact]
        [Trait("Owner","Daniel")]
        [Trait("Category","Calculator")]
        public void Add_Given2DecimalValues_ReturnsDecimal()
        {
            //arrange
            var calculator = new Calculator();

            //act
            var res = calculator.Add(1.23m, 2.24m);

            //assert
            Assert.Equal(3.5m, res, 1);
        }
    }
}
