namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! Welcome to deposit bank, enter the amount you want to deposit!");
            decimal initialDeposit = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("And also select the number of months from 1 to 12!");
            int months = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select option 1 if you want a deposit with capitalization or option 2 without capitalization");
            int withCapitalization = Convert.ToInt32(Console.ReadLine());

            List<DepositData> results = MonthlyDepositCalculation.CalculateMonthlyResult(initialDeposit, months, withCapitalization);

            decimal sum = results.Sum(x => x.Interest);
            decimal avg = results.Average(x => x.Interest);

            Console.WriteLine();

            Console.WriteLine($"{"Month",-10} {"Deposit",-12} {"Interest",-12} {"Balance",-12}");
            Console.WriteLine(new string('-', 45));

            foreach (var item in results)
            {
                Console.WriteLine($"{item.NumberOfMonths, -10} " +
                                  $"{item.Deposit, -12} " +
                                  $"{item.Interest,-12:F2} " +
                                  $"{item.Balance:F2}" );
            }

            Console.WriteLine();

            Console.WriteLine($"Total amount of accured interest for the period {sum:F2}");

            Console.WriteLine();

            Console.WriteLine($"Average monthly income {sum:F2}");
        }
    }
}
