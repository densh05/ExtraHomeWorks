using System;
using System.Collections.Generic;
using System.Text;

namespace ArithmeticOperations
{
    internal static class MathHelper
    {
        public static double Add(double a, double b)
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
                throw new ArgumentException("Denominator cannot be zero!");
            }
            return a / b;
        }

    }
}
