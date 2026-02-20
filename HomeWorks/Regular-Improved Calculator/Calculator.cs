namespace Regular_Improved_Calculator
{
    public class Calculator
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

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error");
                return 0;
            }

            return a / b;
        }
    }
}
