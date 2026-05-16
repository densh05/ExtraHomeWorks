using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Director : Manager
    {
        public override void LogInSystem()
        {
            Console.WriteLine($"Logged in as Boss");
            LogginingLoger<Director>.Log(this);
        }
    }
}
