using System;
using System.Collections.Generic;
using System.Text;
using MyExtraHomeWorks;

namespace Library
{
     class BookWithImages : Book
    {
        private string[] images ;
        private int[] imagespages;
        

        public BookWithImages(string name, string author, int pages, string[] images, int[] imagespages)
            : base(name, author, pages)
        {
            this.images = images;
            this.imagespages = imagespages;
        }
        
        public override void MoveNext()
        {
            if (currentPageNumber < PagesCount)
            {
                currentPageNumber++;
                Console.WriteLine($"Поточна сторінка: {currentPageNumber}");
                byte imageCount = 0;

                for(int i = 0; i < imagespages.Length && imageCount < 2; i++)
                {
                    if (imagespages[i] == currentPageNumber)
                    {
                        Console.WriteLine($"Ця сторінка з картинкою: {images[i]}");
                        imageCount++;   
                    }                               
                }             
            }
            else
            {
                Console.WriteLine("Книга закінчилась");
            }
        }

        
        

    }
}
