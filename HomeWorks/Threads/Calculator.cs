using System;
using System.Collections.Generic;
using System.Text;

namespace Threads
{
    static class Calculator
    {
        public static int CalculateFactorial(int n)
        {
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Thread.Sleep(2000);

            return factorial;
        }

    }
}
