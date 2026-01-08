using System;
using System.Text;
using System.Threading.Channels;

namespace MyExtraHomeWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Book[] books = new Book[]  //Записуємо в користувальницький конструктор классу Воок значення для полів
            {
                new Book("Кобзар","Тарас Шевченко",960),
                new Book("Лісова пісня","Леся Українка",162),
                new Book("Маленький принц","Антуан де Сент-Екзюпері",200)
            };

            MyLibrary library = new MyLibrary(books); //Робимо єкземпеляр классу MyLibrary,в якості аргументу передаємо змінну book  

            Console.WriteLine("Пошук за назвою");
            string title = Console.ReadLine(); //в змінну типу стрінг записуємо значення для пошуку за назвою
            Book found = library[title];

            if (found == null)
            {
                Console.WriteLine("Нічого не знайдено за цією назвою");
            }
            {
                var result = found.GetInfo();
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }

        

        
    }
}
