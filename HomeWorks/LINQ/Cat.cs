using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class Cat
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public int Weight { get; set; }
        public Color Color { get; set; }
        public Breed Breed { get; set; }
        public decimal Price { get; set; }
        public SexType Sex { get; set; }
        public int Age { get; set; }
    }
}
