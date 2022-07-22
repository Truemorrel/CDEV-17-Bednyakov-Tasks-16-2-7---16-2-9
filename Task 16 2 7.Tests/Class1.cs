namespace Task_16_2_7.Tests
{
    public class Class1
    {
        private readonly Calculator _calculator = new();

        [Fact]
        public void SubstructionMustReturnCorrectValue()
        {
            Assert.Equal(4, _calculator.Subtraction(6, 2));
        }

        [Fact]
        public void FailingSubstructionTest()
        {
            Assert.Equal(4, _calculator.Subtraction(6, 2));
        }
    }
}