namespace Calculator.Library
{
    public class Calculator
    {
        public static void Main ()
        { }
        public static int Divide (int numerator , int denominator)
        {
            int result = numerator / denominator;
            return result;
        }
        public static int Multiply(int numerator, int denominator)
        {
            int result = numerator * denominator;
            return result;
        }
        public static int Addition(int numerator, int denominator)
        {
            int result = numerator + denominator;
            return result;
        }
        public static int Subtraction(int numerator, int denominator)
        {
            int result = numerator - denominator;
            return result;
        }
    }
}