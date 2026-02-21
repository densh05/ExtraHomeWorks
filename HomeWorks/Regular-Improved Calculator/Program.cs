using Calculator;
using System.Runtime.ExceptionServices;
class Program
{

    static void Main()
    {
        Calculator.Calculator calculator = new CalculatorPro();

        int attempts = 3;
        string key = "111";
        while (true) 
        {
            Console.WriteLine("Hi, choose ur operation");
            Console.WriteLine("0 Break");
            Console.WriteLine("1 Addition");
            Console.WriteLine("2 Subtract");
            Console.WriteLine("3 Multiply");
            Console.WriteLine("4 Divide");
            Console.WriteLine("5 Sqrt");
            Console.WriteLine("6 Pow");

            string choice = Console.ReadLine();

            double a, b;

            //Console.WriteLine("First number:");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Second number:");
            //b = Convert.ToDouble(Console.ReadLine());


            switch (choice)
            {
                case "1":
                    Console.WriteLine("First number:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Second number:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Calculator.Calculator.Addition(a, b));
                    break;
                case "2":
                    Console.WriteLine("First number:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Second number:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Calculator.Calculator.Subtract(a, b));
                    break;
                case "3":
                    Console.WriteLine("First number:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Second number:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Calculator.Calculator.Multiply(a, b));
                    break;
                case "4":
                    Console.WriteLine("First number:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Second number:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Calculator.Calculator.Divide(a, b));
                    break;

                case "5":
                    if(attempts > 0)
                    {
                        Console.WriteLine("First number:");
                        a = Convert.ToDouble(Console.ReadLine());
                        CalculatorPro calculatorPro = (CalculatorPro)calculator;
                        Console.WriteLine(calculatorPro.SquareRoot(a));
                        attempts--;
                    }
                    else
                    {
                        Console.WriteLine("Attempts are over,enter the access key:");
                        var accessKey = Console.ReadLine(); 
                        if(accessKey == key)
                        {
                            Console.WriteLine("Access granted!");
                            attempts = 3;
                        }
                        else
                        {
                            Console.WriteLine("Input errot");
                        }
                    }
                    break;
                    
                case "6":
                    if(attempts > 0)
                    {
                        Console.WriteLine("First number:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Second number:");
                        b = Convert.ToDouble(Console.ReadLine());
                        CalculatorPro calculatorPro = (CalculatorPro)calculator;
                        Console.WriteLine(calculatorPro.Pow(a, b));
                        attempts--;
                    }
                    else
                    {
                        Console.WriteLine("Attempts are over,enter the access key:");
                        var accessKey = Console.ReadLine();
                        if (accessKey == key)
                        {
                            Console.WriteLine("Access granted!");
                            attempts = 3;
                        }
                        else
                        {
                            Console.WriteLine("Input errot");
                        }
                    }
                   
                    break;

                default:
                    Console.WriteLine("Unknown error");
                    break;

            }           
        }

    }
}