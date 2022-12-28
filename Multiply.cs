namespace TestProject2
{
    [TestClass]
    public class Multiply
    {
        [TestMethod]
        public void Test_Multiply()

        {
            int expected = 80;
            int numerator = 20;
            int denominator = 4;

            int actual = Calculator.Library.Calculator.Multiply(numerator, denominator);
            Assert.AreEqual(expected, actual);
        }
    }
}