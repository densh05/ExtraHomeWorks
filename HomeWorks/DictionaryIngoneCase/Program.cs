namespace DictionaryIgnoreCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Dictionary<string, string> dict = new(StringComparer.OrdinalIgnoreCase)
            {
                ["Cat"] = "Luna",
                ["CAT"] = "Masik",
                ["CaT"] = "Michael",
                ["Dog"] = "Robby",
                ["DOg"] = "Bobby",
                ["dog"] = "Korry"
            };

            Console.WriteLine(dict["Cat"]);
            Console.WriteLine(dict["cat"]);
            Console.WriteLine(dict["CAT"]);
            Console.WriteLine(dict["CaT"]);

            Console.WriteLine(dict["Dog"]);
            Console.WriteLine(dict["dog"]);
            Console.WriteLine(dict["DOg"]);
        }
    }
}
