using System;
using System.Collections.Generic;
using System.Text;

namespace UserCollections
{
    abstract class Animal
    {
        public abstract string Name { get; init; }
        public abstract int Weight { get; init; }
        public abstract int Age { get; init; }
        public abstract AnimalType Type { get; init; }
        public abstract void MakeSound();
    }
}
