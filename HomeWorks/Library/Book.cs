using System;
using System.Collections.Generic;
using System.Text;

namespace MyExtraHomeWorks
{
    internal class Book
    {
    
        public Book(string name, string author, int pages) //Приймається значення з базового классу
        {
            Name = name;
            Author = author;
            Pages = pages;
        }

        public string Name { get; }
        public string Author { get; }
        public int Pages { get; }

        public void ShowInfo()
        {
            Console.WriteLine("Назва книги" + " " + Name);
            Console.WriteLine("Автор книги" + " " + Author);
            Console.WriteLine("Кількість сторінок" + " " + Pages);
        }
    }


    
}
