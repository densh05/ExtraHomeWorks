using Calculator;
using System.Runtime.ExceptionServices;
class Program
{

    static void Main()
    {
        CalculatorOrdinary calculator = new CalculatorPro();

        bool isActivated = false;
        int attempts = 3;
        const string key = "111";
        string error = string.Empty;

        while (true) 
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Hi, choose ur operation");
            Console.WriteLine("0 Break");
            Console.WriteLine("1 Addition");
            Console.WriteLine("2 Subtract");
            Console.WriteLine("3 Multiply");
            Console.WriteLine("4 Divide");

            if (attempts <= 3 || isActivated)
            {
                Console.WriteLine("5 Sqrt");
                Console.WriteLine("6 Pow");
            }

            string choice = Console.ReadLine();
            double a, b, result = 0;


            switch (choice)
            {
                case "1":
                    a = RequestOperand("Input first oerand");
                    b = RequestOperand("Second number: ");
                    result = CalculatorOrdinary.Addition(a, b);
                    break;
                case "2":
                    a = RequestOperand("Input first oerand");
                    b = RequestOperand("Second number: ");
                    result = CalculatorOrdinary.Subtract(a, b);
                    break;
                case "3":
                    a = RequestOperand("Input first oerand");
                    b = RequestOperand("Second number: ");
                    result = CalculatorOrdinary.Multiply(a, b);
                    break;
                case "4":
                    a = RequestOperand("Input first oerand");
                    b = RequestOperand("Second number: ");
                    result = CalculatorOrdinary.Divide(a, b, out error);
                    break;

                case "5":
                    if (attempts > 0)
                    {
                        a = RequestOperand("Input first oerand");
                        CalculatorPro calculatorPro = (CalculatorPro)calculator;
                        result = calculatorPro.SquareRoot(a);
                        attempts--;
                    }
                    else
                    {
                        attempts = RequestKey(attempts, key);
                    }
                    break;
                case "6":
                    if (attempts > 0)
                    {
                        a = RequestOperand("Input first oerand");
                        b = RequestOperand("Second number: ");
                        CalculatorPro calculatorPro = (CalculatorPro)calculator;
                        result = calculatorPro.Pow(a, b);
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
            if (error == string.Empty)
            {
                Console.WriteLine($"Result = {result}");
            }
            else
            {
                Console.WriteLine($"Error occured with message {error}");
            }
        }
    }

    private static int RequestKey(int attempts, string key)
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

        return attempts;
    }

    private static double RequestOperand(string text)
    {
        Console.WriteLine(text);
        string answer = Console.ReadLine();

        if (double.TryParse(answer, out double result))
        {
            return result;
        }

        Console.WriteLine("You inputed not number");
        return -1;
    }
}