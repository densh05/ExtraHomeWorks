namespace Calculator
{
     public class CalculatorPro : CalculatorOrdinary
    {
        public double SquareRoot(double a)
        {
            return Math.Sqrt(a);
        }

        public double Pow(double a, double x)
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
