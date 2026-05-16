using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int Id { get; set; }
    }
}
