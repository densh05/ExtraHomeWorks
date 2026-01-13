namespace MyExtraHomeWorks
{
    class Book
    {
        protected int currentPageNumber = 1; // поле-внутрішня змінна для відстеження поточної сторінки 
        public int CurrentPageNumber { get { return currentPageNumber; } } // властивість для отримання номера поточної сторінки    
        
        public string CurrentPage { get { return pageContent[currentPageNumber - 1]; } } // властивість для отримання вмісту поточної сторінки

        protected readonly string[] pageContent; // поле-внутрішня змінна-масив інакпсулюємо внутрішній стан об'єкта

        public Book(string name, string author, int pagesCount) // Приймається значення з базового класу або конструктора
        {
            Name = name;
            Author = author;
            PageCount = pagesCount;
            pageContent = new string[PageCount];
        }

        public string Name { get; } 
        public string Author { get; }
        public int PageCount { get; }


        public void LoadPage(string content, int pageNumber)
        {
            if (pageNumber >= 0 && pageNumber <= pageContent.Length)
            {
                pageContent[pageNumber - 1] = content;
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

        public string Open()
        {
            string result = @$"Назва книги  {Name} 
Автор книги {Author}
Кількість сторінок {PageCount}";

            return result;
        }
     }  
}
