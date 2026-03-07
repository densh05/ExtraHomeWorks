namespace Calculator
{
    public class CalculatorOrdinary
    {
        public static double Addition(double a, double b)
        {
            return a + b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b, out string errorMessage)
        {
            if (b == 0)
            {
                errorMessage = "Try diving by zero";
                return -1;
            }
            
            errorMessage = string.Empty;
            return a / b;
        }
    }
}
