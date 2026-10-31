using System.Text;

namespace TextWorking
{
    internal class Program
    {
        private const string Separation = " : ";

        static void Main(string[] args)
        {
            Point point = new (12, 45, ConsoleColor.Red);

            Console.WriteLine(point.ToString());
            Console.WriteLine($"Format G: {point:G}");
            Console.WriteLine($"Format M: {point:M}");
            Console.WriteLine($"Format FL: {point:FL}");
            //Console.WriteLine($"Format Default: {point:A}");

            Console.WriteLine(new string('-', 50));

            const string text = "I love programming in C#!";
            const string myFile = "text.txt";

            var swUtf8 = new StreamWriter(myFile, false, Encoding.UTF8);
            swUtf8.WriteLine(text);
            swUtf8.Close();

            StreamReader reader = new(myFile, Encoding.UTF8);
            Console.WriteLine($"Content: {reader.ReadToEnd()}");
            reader.Close();

            byte[] utf16Bytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, Encoding.UTF8.GetBytes(text));

            var builder = new StringBuilder();
            foreach (byte b in utf16Bytes)
            {
                builder.Append(b).Append(Separation);
            }
            Console.WriteLine(builder);
        }
    }
}
