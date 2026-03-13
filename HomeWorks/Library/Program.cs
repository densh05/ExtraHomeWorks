using Library;
using System;
using System.Collections;
using System.Text;

namespace MyExtraHomeWorks
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            //====================================================================

            var book15 = new Book("Shutter Island", "Lem", GenerateBookContent(5));

            foreach (Page page in book15)
            {
                Console.WriteLine($"Number of page={page.Number}");
                Console.WriteLine(page.Text);
            }

            foreach (Page page in book15)
            {
                Console.WriteLine($"Number of page={page.Number}");
                Console.WriteLine(page.Text);
            }

            // foreach
            IEnumerator enumerator = book15.GetEnumerator();    
            while (enumerator.MoveNext())
            {
                Page page = (Page)enumerator.Current;
                Console.WriteLine($"Number of page={page.Number}");
                Console.WriteLine(page.Text);
            }

            //====================================================================


            Page[] pagesForKobzar = GenerateBookContent(3);

            Book[] books =  //Записуємо в користувальницький конструктор классу Воок значення для полів
            [          
                new Book("Кобзар","Тарас Шевченко", pagesForKobzar),
                new Book("Лісова пісня","Леся Українка", GenerateBookContent(3)),
                new Book("Маленький принц","Антуан де Сент-Екзюпері", GenerateBookContent(3)),
                // Поліморфізм - неявний up cast до базового класу Book
               // UPCASTING-1
                new BookWithImages("C#", "Jeffry Richter", GenerateBookContentWithImages(3)) // up-cast до классу Book
                {
                    TitleImage = "C# Logo"
                }
            ];

            var library = new MyLibrary(books); // Робимо екземпеляр класу MyLibrary, в якості аргументу передаємо змінну books 

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
                                Console.WriteLine($"Сторінка номер {((Page)found.Current).Number}");
                                Console.WriteLine(((Page)found.Current).Text);

                                if (found is BookWithImages bookWithImages)
                                {
                                    PageWithImages pageWithImages = (PageWithImages)bookWithImages.Current;
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
            string text;   
            string[] words = ["Привіт", "справи", "ти", "бувай", "забув", "може", "яблуко", "якщо", "шість", "козак"];
            Random randomizer = new Random(); //Method random for future content in pages

            for (int i = 0; i < pageCount; i++) //Filling pages
            {
                text = string.Empty;

                for (int j = 0; j < 3 ; j++)
                {
                    int index = randomizer.Next(0, words.Length - 1); //Індекс дорівнює рандомному єлементу масива від 0 до 9,викликаємо метод і отримуємо рандомне число
                    text += words[index] + " ";  //В результат записуємо 3 рандомних слова
                }

                pages[i] = new Page(text, i + 1); //Передаємо в клас Пейдж результат з трьох слів та номер сторінки
            }

            return pages; //Повертаємо усі сторінки з контентом в користувальницький конструктор класу Воок
        }

        public static PageWithImages[] GenerateBookContentWithImages(int pageCount)
        {

            PageWithImages[] pages = new PageWithImages[pageCount];
            string text;
            string[] words = ["Привіт", "справи", "ти", "бувай", "забув", "може", "яблуко", "якщо", "шість", "козак"];
            string[] images = ["Cat", "Cloud", "Rain", "Snow", "Fisher", "Bastion", "Door", "Cup", "House", "Tea"];
            Random randomizer = new Random();

            for (int i = 0; i < pageCount; i++)
            {
                text = string.Empty;

                for (int j = 0; j < 3; j++)
                {
                    int index = randomizer.Next(0, words.Length - 1);
                    text += words[index] + " ";
                }

                int imageIndex = randomizer.Next(-1, images.Length - 1);
                string image = (imageIndex == -1) ? null : images[imageIndex];

                pages[i] = new PageWithImages(text, i  + 1, image);
            }

            return pages;
        }
    }
}
