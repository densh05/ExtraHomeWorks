using System;
using System.Collections.Generic;
using System.Text;

namespace MyExtraHomeWorks
{
    internal class MyLibrary(Book[] books)
    {
        private readonly Book[] books = books;

        public Book this[string bookname]
        {
            get
            {
                return GetBookByName(bookname); 
            }

        }

        private Book GetBookByName(string title) //Приймається значення від змінної title в класі Program
        {
            for (int i = 0; i < books.Length; i++) //Циклом перевіряємо всі існуючі книги в масиві
            {
                if (books[i].Name == title)
                {
                    return books[i];    
                }
            }
            
            return null;
        }
    }
}
