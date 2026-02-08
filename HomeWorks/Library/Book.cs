using Library;
using System.Text;

namespace MyExtraHomeWorks
{
    class Book(string name, string author, Page[] pages)
    {

        protected Page[] pages = pages;
        protected int currentPageNumber = 0;
         // поле-внутрішня змінна для відстеження поточної сторінки 

        public string Name { get; } = name;
        public string Author { get; } = author;
        public int PageCount { get; } = pages.Length;
        public Page this[int number]
        {
            get
            {
                for (int i = 0; i < pages.Length; i++)
                {
                    if (pages[i].Number == number)
                    return pages[i];
                }

                return null; 
            }
        }

        public Page CurrentPage
        {
            get
            {
                return this[currentPageNumber];
            }
        }

        public virtual bool MoveNext()
        {
            if (currentPageNumber < PageCount)
            {
                currentPageNumber++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            currentPageNumber = 0;
        }

        public virtual string Open()
        {
            string result = @$"Назва книги  {Name} 
Автор книги {Author}
Кількість сторінок {PageCount}";

            return result;
        }
     }  
}
