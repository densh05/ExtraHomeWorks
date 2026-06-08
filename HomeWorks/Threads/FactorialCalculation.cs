using System;
using System.Collections.Generic;
using System.Text;

namespace Threads
{
    class FactorialCalculation
    {
        static readonly object locker = new object();

        public void Calculate(int n)
        {
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Thread.Sleep(2000);

            lock (locker)
            {
                switch (n)
                {
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    case 9:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    case 10:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"Thread #{n} is {factorial}");
                Console.ResetColor();
            }
        }
    }
}
