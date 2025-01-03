namespace TestProject1
{

    public class StringCalculatorTests
    {
        [Fact]
        public void Add_MultipleNumbers_ReturnsSum()
        {
            // Arrange
            var calculator = new StringCalculator();

            // Act
            var result = calculator.Add("1,2,3");

            // Assert
            Assert.Equal(6, result);
        }
    }

}