namespace Library
{
    class Page(string text, int number)
    {
        public int Number { get; } = number;
        public string Text { get; } = text;
        public int Chapter { get; init; }
    }
}
