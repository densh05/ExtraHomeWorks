using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Manager : Employee
    {
        public string Department { get; set; }

        public override void LogInSystem()
        {
            Console.WriteLine($"Logged in as {Position}");
            LogginingLoger<Manager>.Log(this);
        }
    }
}
