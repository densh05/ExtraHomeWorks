using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
       
    }
}
