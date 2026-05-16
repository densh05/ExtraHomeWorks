using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    internal class Engineer : Employee
    {
        public Experience ExperienceLevel { get; set; }

        public override void LogInSystem()
        {
            Console.WriteLine($"Logged in as Engineer");
            LogginingLoger<Engineer>.Log(this);
        }
    }
}
