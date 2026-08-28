namespace Arithmetic
{
    public class Calculator
    {
        public static double AscensionToPower(double baseValue, double exponent)
        {
            return Math.Pow(baseValue, exponent);
        }

        public static double SquareRoot(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Cannot calculate square root of a negative number.");
            }
            return Math.Sqrt(value);
        }

        protected static double ChangeOfSign(double value)
        {
            return -value;
        }

    }
}
