namespace Addition
{
    [TestClass]
    public class Addition
    {
        [TestMethod]

        public void Test_Addition()

        {
            int expected = 24;
            int numerator = 20;
            int denominator = 4;

            int actual = Calculator.Library.Calculator.Addition(numerator, denominator);
            Assert.AreEqual(expected, actual);
        }
    }
}