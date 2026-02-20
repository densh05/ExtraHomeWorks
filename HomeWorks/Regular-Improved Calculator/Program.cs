using Regular_Improved_Calculator;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{

    static void Main()
    {
        Calculator calculator = new CalculatorPro();

        int attempts = 3;
        string key = "111";

        while (true) 
        {

            Console.WriteLine("Hi,choose ur operation");
            Console.WriteLine("0 Break");
            Console.WriteLine("1 Addition");
            Console.WriteLine("2 Subtract");
            Console.WriteLine("3 Multiply");
            Console.WriteLine("4 Divide");
            Console.WriteLine("5 Sqrt");
            Console.WriteLine("6 Pow");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0) break;

            double a, b;

            if (choice >= 1 && choice <= 4)
            {
                
                    Console.WriteLine("First number:");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Second number:");
                    b = Convert.ToDouble(Console.ReadLine());

                    if (choice == 1) Console.WriteLine(Calculator.Addition(a, b));
                    if (choice == 2) Console.WriteLine(Calculator.Subtract(a, b));
                    if (choice == 3) Console.WriteLine(Calculator.Multiply(a, b));
                    if (choice == 4) Console.WriteLine(Calculator.Divide(a, b));
            }

            else if (choice == 5 || choice == 6)
            {
                CalculatorPro calculatorPro = (CalculatorPro)calculator;

                if (attempts > 0)
                {
                    if (choice == 5)
                    {
                        Console.WriteLine("Square root calculation");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(CalculatorPro.SquareRoot(a));
                    }
                    else
                    {
                        Console.WriteLine("Number to be raised to a power:");
                        Console.WriteLine("First number:");
                        a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Second number:");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(CalculatorPro.Pow(a, b));

                    }
                    attempts--;
                }
                else 
                {
                    Console.WriteLine("Enter the key if u want to get PRO access");
                    string result = Console.ReadLine();

                    if (result == key)
                    {
                        calculator = new CalculatorPro();
                        attempts = 3;
                        Console.WriteLine("Activated");
                    }
                    else
                    {
                        Console.WriteLine("Wrong key");
                    }
                }
            } 
        }

    }
}