using Library;
using System;
using System.Text;

namespace MyExtraHomeWorks
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Book[] books =  //Записуємо в користувальницький конструктор классу Воок значення для полів
            [
                new Book("Кобзар","Тарас Шевченко", GenerateBookContent(3)),
                new Book("Лісова пісня","Леся Українка", GenerateBookContent(3)),
                new Book("Маленький принц","Антуан де Сент-Екзюпері", GenerateBookContent(3)),
                // Поліморфізм - неявний up cast до базового класу Book
               // UPCASTING-1
                new BookWithImages("C#", "Jeffry Richter", GenerateBookContentWithImages(3)) // up-cast до классу Book
                {
                    TitleImage = "C# Logo"
                }
            ];

            var library = new MyLibrary(books); // Робимо екземпеляр класу MyLibrary, в якості аргументу передаємо змінну book  

            while (true)
            {
                Console.WriteLine("Привіт!");
                Console.WriteLine("Введіть назву книги, яку хотіли б прочитати в нашій електронній бібліотеці");
                string title = Console.ReadLine(); //в змінну типу стрінг записуємо значення для пошуку за назвою
                Book found = library[title];

                if (found == null)
                {
                    Console.WriteLine("Нічого не знайдено за цією назвою");
                }
                else
                {
                    var result = found.Open();
                    Console.WriteLine(result);

                    // Читаємо книгу посторінково, якщо це книга з ілюстраціями то виводимо і їх
                    while (found.MoveNext())
                    {
                        Console.WriteLine("1-Далі...");
                        Console.WriteLine("2-З початку");
                        Console.WriteLine("3-Вихід");

                        var choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                Console.WriteLine($"Сторінка номер {found.CurrentPage.Number}");
                                Console.WriteLine(found.CurrentPage.Text);

                                if (found is BookWithImages bookWithImages)
                                {
                                    var pageWithImages = (PageWithImages)bookWithImages.CurrentPage;
                                    Console.WriteLine(pageWithImages.Image);
                                }
                                break;
                            case "2":
                                found.Reset();
                                break;
                            case "3":
                                goto exit;
                            default:
                                Console.WriteLine("Невірний вибір");
                                break;
                        }
                    }
                }
            }
        exit:
            // Поліморфізм

            // DOWNCASTING
            BookWithImages bookWithImagesUpCasted = library["C#"] as BookWithImages; // down-cast до классу BookWithImages попередньо зробленого up-cast до классу Book
            if (bookWithImagesUpCasted != null)
            {
                bookWithImagesUpCasted.Reset();
                Console.WriteLine(bookWithImagesUpCasted.TitleImage);
            }

            // те саме простіше 
            if (bookWithImagesUpCasted is BookWithImages bookWithImages2)
            {
                bookWithImages2.Reset();
                Console.WriteLine(bookWithImages2.TitleImage);
            }

            // UPCASTING-3
            Book bookUpCasted = bookWithImagesUpCasted; // up-cast до все скрили властивість TitleImage але вона є просто скрита
        }

        // Поліморфізм адже можна передлавати як клас Book так і клас BookWithImages
        public static Page[] GenerateBookContent(int pageCount)
        {

            Page[] pages = new Page[pageCount];
            string result;   
            string[] words = ["Привіт", "справи", "ти", "бувай", "забув", "може", "яблуко", "якщо", "шість", "козак"];
            Random randomizer = new Random();

            for (int i = 0; i < pageCount; i++)
            {
                result = string.Empty;

                for (int j = 0; j < 10 ; j++)
                {
                    int index = randomizer.Next(0, words.Length - 1);
                    result += words[index] + " ";
                }

                pages[i] = new Page(result, i + 1); 
            }

            return pages;
        }

        public static PageWithImages[] GenerateBookContentWithImages(int pageCount)
        {

            PageWithImages[] pages = new PageWithImages[pageCount];
            string result;
            string[] words = ["Привіт", "справи", "ти", "бувай", "забув", "може", "яблуко", "якщо", "шість", "козак"];
            string[] images = ["Cat", "Cloud", "Rain", "Snow", "Fisher", "Bastion", "Door", "Cup", "House", "Tea"];
            Random randomizer = new Random();

            for (int i = 0; i < pageCount; i++)
            {
                result = string.Empty;

                for (int j = 0; j < 10; j++)
                {
                    int index = randomizer.Next(0, words.Length - 1);
                    result += words[index] + " ";
                }

                int imageIndex = randomizer.Next(-1, images.Length - 1);
                string image = (imageIndex == -1) ? null : images[imageIndex];

                pages[i] = new PageWithImages(result, i + 1, image);
            }

            return pages;
        }
    }
}
