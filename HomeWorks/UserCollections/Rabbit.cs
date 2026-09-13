using System;
using System.Collections.Generic;
using System.Text;

namespace UserCollections
{
    class Rabbit (string name, int weight, int age, AnimalType type) : Animal
    {
        public override string Name { get; init; } = name;
        public override int Weight { get; init; } = weight;
        public override int Age { get; init; } = age;  
        public override AnimalType Type { get; init; } = type;

        public override void MakeSound()
        {
            Console.WriteLine("Squeak!");
        }
    }
    
}
