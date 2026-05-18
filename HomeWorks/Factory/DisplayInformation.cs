using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    static class DisplayInformation
    {
       public static void DisplayCollectionOnConsole<T>(this IEnumerable<T> checkpoint)
       {
           foreach (var item in checkpoint)
           {
               Console.WriteLine(item);
           }
       }
    }
}
