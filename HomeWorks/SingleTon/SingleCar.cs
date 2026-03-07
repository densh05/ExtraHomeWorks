using System;
using System.Collections.Generic;
using System.Text;

namespace SingleTon
{
    public class SingleCar
    {
        static int counter = 0;
        private static SingleCar instance = null;

        public static SingleCar GetSingleCar()
        {
            if (instance is null || counter <= 2)
            {
                counter++;
                instance = new SingleCar();
            }


            return instance;
        }
        protected SingleCar()
        {

        }
    }
}
