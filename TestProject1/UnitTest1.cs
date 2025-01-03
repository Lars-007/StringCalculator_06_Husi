namespace TestProject1
{

    public class StringCalculatorTests
    {
        [Fact]
        public void Add_EmptyString_ReturnsZero()
        {
            // Arrange
            var calculator = new StringCalculator();

            // Act
            var result = calculator.Add("");

            // Assert
            Assert.Equal(0, result);
        }
    }

}