using System;
using System.Collections.Generic;
using System.Text;

namespace MyExtraHomeWorks
{
     class Book
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

        public string GetInfo()
        {
            string result = @$"Назва книги  {Name} 
Автор книги {Author}
Кількість сторінок {Pages}";

            return result;
        }
    }


    
}
