using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                const string pattern = @"\(\d{3}\)\d{3}[-=]\d{2}[-=]\d{2}";

                string phoneNumber = Console.ReadLine() ?? string.Empty;
                string secondaryVerification = Regex.Replace($"{phoneNumber}", @"=", "-");

                if (Regex.IsMatch(secondaryVerification, pattern))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NO");
                }

                Console.ResetColor();
            }
        }
    }
}
