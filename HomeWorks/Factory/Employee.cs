using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    abstract class Employee : Person
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public abstract void LogInSystem();
    }
}
