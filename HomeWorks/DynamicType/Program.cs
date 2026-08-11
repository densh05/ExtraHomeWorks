namespace DynamicType
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayDynamicType(5, 10);
            DisplayDynamicType(5.7, 10.2);
            DisplayDynamicType(17, " Hello");
            DisplayDynamicType("Hello", " World");
            DisplayDynamicType(true, false);
        }

        static void DisplayDynamicType(dynamic a , dynamic b)
        {
            switch (a)
            {
                case int:
                case double:
                case float:
                case decimal:
                case long:
                case short:
                case byte:
                    Console.WriteLine($"Sum: {a + b}");
                    break;

                case string:
                    Console.WriteLine($"Concatenation: {a + b}");
                    break;

                default:
                    Console.WriteLine("Wrong type");
                    break;
            }
        }
    }
}
