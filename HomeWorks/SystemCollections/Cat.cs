using System;
using System.Collections.Generic;
using System.Text;

namespace SystemCollections
{
    class Cat : Animal
    {
        public BreedType Breed { get; set; }
        public void Play()
        {
            Console.WriteLine($"Today {Name} is playing very happily.");
            Console.WriteLine(new string('-', 50));
        }
        public void Sleep()
        {
            Console.WriteLine($"Today {Name} is sleeping very peacefully.");
            Console.WriteLine(new string('-', 50));
        }
    }
}
