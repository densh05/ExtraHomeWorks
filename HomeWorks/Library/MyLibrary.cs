using System;
using System.Collections.Generic;
using System.Text;

namespace MyExtraHomeWorks
{
    internal class MyLibrary
    {
        private Book[] books;

        public MyLibrary(Book[] books) //Приймаються значення для полів книг
        {
            this.books = books;
        }

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
