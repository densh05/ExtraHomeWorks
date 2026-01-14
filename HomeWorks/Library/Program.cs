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
                new Book("Кобзар","Тарас Шевченко", 960),
                new Book("Лісова пісня","Леся Українка", 162),
                new Book("Маленький принц","Антуан де Сент-Екзюпері", 200),
                // Поліморфізм - неявний up cast до базового класу Book
               // UPCASTING-1
                new BookWithImages("C#", "Jeffry Richter", 15, ["sun", "fish"], [7, 10]) // up-cast до классу Book
                {
                    TitleImage = "C# Logo"
                }
            ];

            for (int i = 0; i < books.Length; i++)
            {
                // UPCASTING-2
                LoadBookContent(books[i]);
            }

            var library = new MyLibrary(books); // Робимо екземпеляр класу MyLibrary, в якості аргументу передаємо змінну book  

            Console.WriteLine("Привіт!\nВведіть назву книги, яку хотіли б прочитати в нашій електронній бібліотеці");
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
                            Console.WriteLine($"Сторінка номер {found.CurrentPageNumber}");
                            Console.WriteLine(found.CurrentPage);

                            if (found is BookWithImages bookWithImages)
                            {
                                for (int k = 0; k < bookWithImages.CurrentImages.Length; k++)
                                   if (bookWithImages.CurrentImages[k] != null)
                                      Console.WriteLine(bookWithImages.CurrentImages[k]);
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
        public static void LoadBookContent(Book book)
        {
            for (int i = 1; i < book.PageCount; i++)
            {
                book.LoadPage(@$"Це історія надзвичайної пригоди, яку втнула ватага ґномів, узявшись відшукати загарбане драконом золото. 
Мимохіть учасником цієї ризикованої виправи став Більбо Торбин, прихильний до комфорту і позбавлений амбіцій гобіт, котрий, на власний подив, виявив неабияку винахідливість і вправність у ролі зломщика. 
Сутички з тролями, ґоблінами, ґномами, ельфами та гігантськими павуками, бесіда з драконом, Смоґом Величним, і радше мимовільна присутність на Битві П’ятьох Армій — ось лише деякі пригоди, що їх судилося пережити Більбо.
Але траплялись і світліші моменти: щира дружба, смачне частування, сміх та пісні. Написаний професором Толкіном для власних дітей, «Гобіт» відразу ж по виході у світ зустрів палке схвалення. 
Ця дивовижна історія, цілком закінчена та вивершена, водночас є преамбулою до «Володаря Перснів».", i);
            }
        }
    }
}
