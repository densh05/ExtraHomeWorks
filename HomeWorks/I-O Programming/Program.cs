namespace I_O_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var directory = new DirectoryInfo(@"C:\Test");
            directory.Create();

            string message = "Hello my dear friend!";
            
            directory.CreateSubdirectory("HelloByByte");
            directory.CreateSubdirectory("HelloByString");

            string filePath = @"C:\Test\HelloByString\HelloByString.txt";
            string filePath2 = @"C:\Test\HelloByByte\HelloByByte.txt";

            var file = new FileInfo(filePath);

            StreamWriter writer = file.CreateText();

            writer.WriteLine(message);
            writer.Close();

            StreamReader read = File.OpenText(filePath);
            string? text;

            while ((text = read.ReadLine()) != null)
            {
                Console.WriteLine(text);
            }

            read.Close();

            FileStream file2 = File.Create(filePath2);
            var writer2 = new BinaryWriter(file2);

            writer2.Write(message);
            file2.Position = 0;

            var reader2 = new BinaryReader(file2);

            byte[] readMessage = reader2.ReadBytes((int)file2.Length);
            Console.WriteLine(string.Join("-", readMessage));

            writer2.Close();
            reader2.Close();

            Console.WriteLine("The deletion has begun");

            directory.Delete(true);

            Console.WriteLine("Deletion complete");
        }
    }
}