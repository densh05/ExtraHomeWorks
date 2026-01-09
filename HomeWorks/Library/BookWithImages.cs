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
        private int currentPage = 0;

        public BookWithImages(string name, string author, int pages, string[] images, int[] imagespages)
            : base(name, author, pages)
        {
            this.images = images;
            this.imagespages = imagespages;

            
        }
        
        public void Next()
        {
            if(currentPage < Pages)
            {
                currentPage++;
                Console.WriteLine($"Поточна сторінка: {currentPage }");

                for( int i = 0; i < images.Length; i++ )
                {

                }
            }
        }
        

    }
}
