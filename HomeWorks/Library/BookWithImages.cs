using MyExtraHomeWorks;

namespace Library
{
     class BookWithImages : Book
    {
        private readonly string[] images; // чому ми робимо ці поля readonly?
        private readonly int[] imagespages; // чому ми робимо ці поля readonly?

        public BookWithImages(string name, string author, int pages, string[] images, int[] imagespages)
            :base(name, author, pages)
        {
            this.images = images;
            this.imagespages = imagespages;
        }

        public string[] CurrentImages { get; private set; }

        public required string TitleImage { get; init; }  

        public override bool MoveNext()
        {
            if (base.MoveNext())
            {
                int imageCount = 0;
                string[] foundImages = new string[2];

                for (int i = 0; i < imagespages.Length && imageCount < 2; i++)
                {
                    if (imagespages[i] == CurrentPageNumber
                        )
                    {
                        foundImages[imageCount++] = images[i];
                    }
                }

                CurrentImages = foundImages;   
                
                return true;    
            }

            return false;   
        }  
        
        public override string Open()
        {
            string result = base.Open();
            result += $"\nОбкладинка книги: {TitleImage}";
            result += $"\nЦя книга містить {imagespages.Length} сторінок з картинками.";
            return result;
        }
    }
}
