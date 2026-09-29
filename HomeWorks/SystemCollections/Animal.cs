using System;
using System.Collections.Generic;
using System.Text;

namespace SystemCollections
{
    abstract class Animal
    {
       public void Info()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Color: {Color}, Volume: {Volume}, Weight: {Weight}");
            Console.WriteLine(new string('-', 50));
        }
        public required string Name { get; set; }
        public int Age { get; set; }
        public string? Color { get; set; }
        public int Volume { get; set; }
        public double Weight { get; set; }
    }
}
