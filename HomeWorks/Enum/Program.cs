using Enum;

class Program
{
    static void Main()
    {
        MyTask[] tasks = 
        [
            new MyTask { Id = 1, CreationDate = DateTime.Now, Description = "Task 1", Status = ProgressType.Suspended },
            new MyTask { Id = 2, CreationDate = DateTime.Now, Description = "Task 2", Status = ProgressType.Started },
            new MyTask { Id = 3, CreationDate = DateTime.Now, Description = "Task 3", Status = ProgressType.Finished },
            new MyTask { Id = 4, CreationDate = DateTime.Now, Description = "Task 4", Status = ProgressType.InProgress }
        ];

        foreach (var task in tasks)
        {
            switch (task.Status)
            {
                case ProgressType.Suspended:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case ProgressType.Started:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case ProgressType.Finished:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case ProgressType.InProgress:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

            }
            Console.WriteLine($"Task ID: {task.Id}, Description: {task.Description}, Status: {task.Status}");
        }

       
    }
}
