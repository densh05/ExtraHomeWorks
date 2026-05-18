using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public static class ArrayExtensions
    {
        public static IEnumerable<int> LessThanZero(this int[] array)
        {
            List<int> negativeNumbers = new List<int>();

            foreach(int number in array)
            {
                if(number < 0)
                {
                    negativeNumbers.Add(number);
                }
            }
             return negativeNumbers;
        }
    }
}
