using MyExtraHomeWorks;

namespace Library
{
     class BookWithImages(string name, string author, PageWithImages[] pages) 
         : Book(name, author, pages)
    {

        public required string TitleImage { get; init; }  

        public override string Open()
        {
            string result = base.Open();
            result += $"\nОбкладинка книги: {TitleImage}";
            result += $"Ця книга містить {pages.Length} сторінок з картинками.";
            return result;
        }
    }
}
