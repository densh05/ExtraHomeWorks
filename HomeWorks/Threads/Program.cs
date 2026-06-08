using Threads;
using System.Threading;

class Program
{
    static void Main()
    {
        FactorialCalculation calc = new FactorialCalculation();

        for (int i = 5; i <= 10; i++)
        {
            int number = i;
            new Thread(() => calc.Calculate(number)).Start(); //Start second thread
        }

        calc.Calculate(25); //Start first thread 
    }
}