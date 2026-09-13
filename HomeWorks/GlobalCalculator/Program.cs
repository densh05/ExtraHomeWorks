using Arithmetic;
using ArithmeticOperations;


namespace GlobalCalculator
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            CustomCalculator calculator = new CustomCalculator();

            double[] array = {17.2, 25.65, -32.3, 54, -10.1, -19.9, -23, 77.65 };
            double[] result = calculator.Recalculation(array);
            Console.WriteLine($"Result: {string.Join(", ", result)}");

            Console.WriteLine(new string('-', 50));

            var res = ArithmeticOperations.Calculator.Add(5, 10);
            Console.WriteLine($"5 + 10 = {res}");

            var res2 = ArithmeticOperations.Calculator.Subtract(15, 7);
            Console.WriteLine($"15 - 7 = {res2}");

            var res3 = ArithmeticOperations.Calculator.Multiply(6, 8);
            Console.WriteLine($"6 * 8 = {res3}");

            var res4 = ArithmeticOperations.Calculator.Divide(20, 4);
            Console.WriteLine($"20 / 4 = {res4}");
        }
    }
}
