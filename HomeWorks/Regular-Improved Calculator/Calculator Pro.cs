namespace Regular_Improved_Calculator
{
     class CalculatorPro : Calculator
    {
        public static double SquareRoot(double a)
        {
            return Math.Sqrt(a);
        }

        public static double Pow(double a, double x)
        {
            double result = 1;

            for (int i = 0; i < x; i++)
            {
                result *= a;
            }
            return result;
        }

    }
}
