using Generics;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        int[] array = { -5, 3, -2, 7, -1, 0, 4, -12, 5 };
        int[] result = NegativeArray.LessThanZero(array);
        foreach(int num in result)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine(new string('-', 40));

        Dictionary<string, string> dict = new Dictionary<string, string>();

        dict.Add("Яблуко", "Apple");
        dict.Add("Авто", "Car");
        dict.Add("Дівчина", "Girl");
        dict.Add("Дім", "House");
        dict.Add("Кінь", "Horse");
        dict.Add("Книга", "Book");
        dict.Add("Документ", "Document");
        dict.Add("Ключ", "Key");
        dict.Add("Бібліотека", "Library");
        dict.Add("Ліжко", "Bed");

        while (true)
        {
            Console.WriteLine("Hi,write the word u want to translate");
            string word = Console.ReadLine();

            if (word != null && dict.ContainsValue(word))
            {
                foreach (var item in dict)
                {
                    if (item.Value == word)
                    {
                        Console.WriteLine($"The translation of {word} is {item.Key}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Unknown word!");
            }
        }

    }
}
