using Generics;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        int[] array = [-5, 3, -2, 7, -1, 0, 4, -12, 5];
        IEnumerable<int> result = array.LessThanZero();
        foreach(int num in result)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine(new string('-', 40));

        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            { "Яблуко", "Apple" },
            { "Авто", "Car"},
            { "Дівчина", "Girl" },
            { "Дім", "House" },
            { "Кінь", "Horse" },
            { "Книга", "Book" },
            { "Документ", "Document" },
            { "Ключ", "Key" },
            { "Бібліотека", "Library" },
            { "Ліжко", "Bed"}
        };

        while (true)
        {
            Console.WriteLine("Привіт,напиши слово на українській для перекладу");
            string keyWord = Console.ReadLine();

            if (dict.ContainsKey(keyWord))
            {
                string translation = dict[keyWord];
                Console.WriteLine($"Переклад слова {keyWord} це {translation}");   
            }
            else
            {
                Console.WriteLine("Unknown word!");
            }
        }

    }
}
