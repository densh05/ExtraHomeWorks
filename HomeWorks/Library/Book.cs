using System;
using System.Collections.Generic;
using System.Text;

namespace MyExtraHomeWorks
{
    internal class Book
    {
        private string name;
        private string author;
        private int pages;

        public Book(string name, string author, int pages)
        {
            this.name = name;
            this.author = author;
            this.pages = pages;
        }

        public string Id { get; private set; }

        public string Name {  get { return name; } }
        public string Author { get { return author; } }
        public int Pages { get { return pages;} }

        public void ShowInfo()
        {
            Console.WriteLine("Назва книги" + name);
            Console.WriteLine("Автор книги" + author);
            Console.WriteLine("Кількість сторінок" + pages);
        }
    }


    
}
