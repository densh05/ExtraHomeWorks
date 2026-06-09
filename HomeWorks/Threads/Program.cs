using Threads;
using System.Threading;

class Program
{
    static readonly object locker = new object();
    public static void CalculateFactorialAndDisplay(object input)
    {
        if (input is Int32 n)
        {
            int factorial = Calculator.CalculateFactorial(n);

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
                }

                Console.WriteLine($"Thread #{Thread.CurrentThread.GetHashCode()} is {factorial}");
                Console.ResetColor();
            }

        }
    }

    static void Main()
    {

        for (int i = 5; i <= 10; i++)
        {
            //lock (locker)
            {
                new Thread(CalculateFactorialAndDisplay).Start(i); //Start second thread
            }
        }

        CalculateFactorialAndDisplay(25); //Start primary thread 
    }
}
