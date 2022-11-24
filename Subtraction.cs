namespace Subtraction
{
    [TestClass]
    public class Subtraction
    {
        [TestMethod]
        public void sub()
        {
            int expected = 16;
            int number1 = 20;
            int number2 = 4;

            int actual = Arthimetic.Calculator.Subtraction(number1, number2);
            Assert.AreEqual(expected, actual);
        }
    }
}