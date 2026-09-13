namespace UserCollections
{
    internal class Program
    {
        static void Info(ShelterDescription shelter)
        {
            Console.WriteLine($"Shelter: {shelter.ShelterName}");
            Console.WriteLine($"Address: {shelter.Address}");
            Console.WriteLine($"Phone Number: {shelter.PhoneNumber}");
            Console.WriteLine($"Animals: {shelter.Count}");

            foreach (Animal animal in shelter)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine($"Animal: {animal.Name}, Weight: {animal.Weight}, Age: {animal.Age}");
                animal.MakeSound();
            }
        }

        static void Main(string[] args)
        {
            Animal animal1 = new Cat("Fluffy", 5, 3, AnimalType.Cat);
            Animal animal2 = new Dog("Buddy", 10, 5, AnimalType.Dog);
            Animal animal3 = new Cat("Whiskers", 4, 2, AnimalType.Cat);
            Animal animal4 = new Rabbit("Thumper", 2, 1, AnimalType.Rabbit);
            Animal animal5 = new Dog("Max", 12, 6, AnimalType.Dog);
            Animal animal6 = new Rabbit("Bunny", 3, 2, AnimalType.Rabbit);
            Animal animal7 = new Cat("Mittens", 6, 4, AnimalType.Cat);

            ShelterDescription shelter = new ShelterDescription("123 Main St", "Happy Tails Shelter", 1232424)
            {
                animal1,
                animal2,
                animal3,
                animal4,
                animal5,
                animal6,
                animal7
            };

            Info(shelter);

        }
    }
}
