using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class NegativeArray
    {
        public static int[] LessThanZero(int[] array)
        {
            List<int> negativeNumbers = new List<int>();

            foreach(int number in array)
            {
                if(number < 0)
                {
                    negativeNumbers.Add(number);
                }
            }
            return negativeNumbers.ToArray();
        }
    }
}
