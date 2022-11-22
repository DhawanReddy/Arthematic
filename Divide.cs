namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void  Test_Divide()

        {
            int expected = 5;
            int numerator = 20;
            int denominator = 4;

            int actual = Calculator.Library.Calculator.Divide(numerator, denominator);
            Assert.AreEqual(expected, actual);
        }
        
    }
}