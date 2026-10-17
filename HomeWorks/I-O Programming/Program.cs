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

            var file = new FileInfo(@"C:\Test\HelloByString\HelloByString.txt");

            StreamWriter writer = file.CreateText();

            writer.WriteLine(message);
            writer.Close();

            StreamReader read = File.OpenText(@"C:\Test\HelloByString\HelloByString.txt");
            string? text;

            while ((text = read.ReadLine()) != null)
            {
                Console.WriteLine(text);
            }

            read.Close();

            FileStream file2 = new (@"C:\Test\HelloByByte\HelloByByte.txt", FileMode.Create);
            var writer2 = new BinaryWriter(file2);

            writer2.Write(message);
            file2.Position = 0;

            var reader2 = new BinaryReader(file2);
            
            string readMessage = reader2.ReadString();
            Console.WriteLine(readMessage);

            writer2.Close();
            reader2.Close();

            Console.WriteLine("The deletion has begun");

            Directory.Delete(@"C:\Test", true);

            Console.WriteLine("Deletion complete");

        }
    }
}