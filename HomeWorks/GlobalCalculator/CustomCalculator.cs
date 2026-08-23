using ArithmeticOperations;
using Arithmetic;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalCalculator
{
    public class CustomCalculator : Arithmetic.Calculator
    {
        public double[] Recalculation(double[] values)
        {
            double[] result = new double[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < 0)
                {
                    result[i] = ChangeOfSign(values[i]);
                }
                else
                {
                    result[i] = values[i];
                }
            }
            return result;
        }
    }
}
