using System;
using System.Collections.Generic;
using System.Text;

namespace MyExtraHomeWorks
{
     class Book
    {
        protected int currentPageNumber = 0;
        public string CurrentPage { get { return pagesContent[currentPageNumber]; } }

        private readonly string[] pagesContent;
        public Book(string name, string author, int pagesCount) //Приймається значення з базового классу
        {
            Name = name;
            Author = author;
            PagesCount = pagesCount;
            pagesContent = new string[PagesCount];
        }

        public string Name { get; }
        public string Author { get; }
        public int PagesCount { get; }


        public void LoadPage(string content, int pageNumber)
        {
            if (pageNumber >= 0 && pageNumber <= pagesContent.Length)
            {
                pagesContent[pageNumber - 1] = content;
            }
        }

        public virtual void MoveNext()
        {
            if (currentPageNumber < pagesContent.Length)
            currentPageNumber++;
        }

        public void Reset()
        {
            currentPageNumber = 0;
        }

        public string GetInfo()
        {
            string result = @$"Назва книги  {Name} 
Автор книги {Author}
Кількість сторінок {PagesCount}";

            return result;
        }
    }


    
}
