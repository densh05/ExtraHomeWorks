using Factory;

class Program
{
    static void Main()
    {
        Engineer engineer = new Engineer
        {
            Name = "Ivan",
            Email = "ivan@gmail.com",
            PhoneNumber = 0685616,
            Id = 1,
            Position = "Employee",
            Salary = 19950,
            ExperienceLevel = Experience.Mid
        };

        Manager manager = new Manager
        {
            Name = "Oleg",
            Email = "oleg@gmail.com",
            PhoneNumber = 0681213,
            Id = 2,
            Position = "Manager",
            Salary = 28500,
            Department = "Workers department"
        };

        Director director = new Director
        {
            Name = "Andriy",
            Email = "andriy@gmail.com",
            PhoneNumber = 0678345,
            Id = 3,
            Position = "Director",
            Salary = 49000,
            Department = "CEO"
        };

        for(int i = 0; i < 3; i++)
        {
            director.LogInSystem();
        }

        for (int i = 0; i < 2; i++)
        {
            manager.LogInSystem();
        }

        for (int i = 0; i < 4; i++)
        {
            engineer.LogInSystem();
        }

        var logs1 = LogginingLoger<Director>.GetAllLogsBy(director);
        var logs2 = LogginingLoger<Manager>.GetAllLogsBy(manager);
        var logs3 = LogginingLoger<Engineer>.GetAllLogsBy(engineer);

        logs1.DisplayCollectionOnConsole();
        logs2.DisplayCollectionOnConsole();
        logs3.DisplayCollectionOnConsole();

    }
}
