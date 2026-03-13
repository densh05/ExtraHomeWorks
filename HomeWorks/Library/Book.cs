using Library;
using System.Collections;
using System.Text;

namespace MyExtraHomeWorks
{
    class Book(string name, string author, Page[] pages): IEnumerator, IEnumerable
    {
        protected Page[] pages = pages;  //Приймаємо усю інформацію про книгу та контент книги
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

        #region IEnumerator implementation

        public object Current => this[currentPageNumber];      

        public virtual bool MoveNext()
        {
            if (currentPageNumber < PageCount)
            {
                currentPageNumber++;
                return true;
            }

            Reset();
            return false;
        }

        public void Reset()
        {
            currentPageNumber = 0;
        }
        #endregion

        public virtual string Open()
        {
            string result = @$"Назва книги  {Name} 
Автор книги {Author}
Кількість сторінок {PageCount}";

            return result;
        }

        #region IEnumerable implementation

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        #endregion
    }
}
