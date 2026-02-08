namespace Library
{
    class PageWithImages(string text, int number, string image) : Page(text, number)
    {
        public string Image { get; } = image;
    }
}
