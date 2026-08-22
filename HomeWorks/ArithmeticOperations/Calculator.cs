namespace ArithmeticOperations
{
    public static class Calculator
    {
        public static double Add(double a, double b)
        {
            Console.WriteLine($"Adding {a} and {b}");
            return MathHelper.Add(a, b);
        }
        public static double Subtract(double a, double b)
        {
            Console.WriteLine($"Subtracting {b} from {a}");
            return MathHelper.Subtract(a, b);
        }
        public static double Multiply(double a, double b)
        {
            Console.WriteLine($"Multiplying {a} and {b}");
            return MathHelper.Multiply(a, b);
        }
        public static double Divide(double a, double d)
        {
            Console.WriteLine($"Dividing {a} by {d}");
            return MathHelper.Divide(a, d);
        }
    }
}
