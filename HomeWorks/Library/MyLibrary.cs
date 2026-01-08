using System;
using System.Collections.Generic;
using System.Text;

namespace MyExtraHomeWorks
{
    internal class MyLibrary
    {
        private Book[] books;

        public MyLibrary(Book[] books)
        {
            this.books = books;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Length)
                {
                    Book book = books[index];
                    return $"Назва книги {book.Name}\n" +
                       $"Імя автору {book.Author}\n" +
                       $"Кількість сторінок {book.Pages}\n";
                }
                else
                {
                    return "Книгу не знайдено";
                }

            }
            
        }

        public void SearchByName(string title)
        {
            bool found = false;

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Name == title)
                {
                    books[i].ShowInfo();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Невідома книга");
            }
        }



    }
}
