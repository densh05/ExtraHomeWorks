using System;

namespace MyExtraHomeWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
            {
                new Book("Кобзар","Тарас Шевченко",960),
                new Book("Лісова пісня","Леся Українка",162),
                new Book("Маленький принц","Антуан де Сент-Екзюпері",200)
            };
        }

        MyLibrary library = new MyLibrary(books);
    }
}
