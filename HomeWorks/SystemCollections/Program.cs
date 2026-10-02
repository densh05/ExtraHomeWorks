using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace SystemCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var cats = new List<Cat>
            {
                new() { Name = "Whiskers", Age = 2, Color = "Gray", Volume = 5, Weight = 4.5, Breed = BreedType.Persian },
                new() { Name = "Mittens", Age = 3, Color = "Black", Volume = 7, Weight = 5.2, Breed = BreedType.Siamese },
                new() { Name = "Shadow", Age = 1, Color = "White", Volume = 6, Weight = 4.8, Breed = BreedType.MaineCoon },
                new() { Name = "Luna", Age = 4, Color = "Calico", Volume = 8, Weight = 5.0, Breed = BreedType.Persian },
                new() { Name = "Simba", Age = 5, Color = "Orange", Volume = 9, Weight = 5.5, Breed = BreedType.Siamese },
                new() { Name = "Cleo", Age = 2, Color = "Gray", Volume = 4, Weight = 4.0, Breed = BreedType.MaineCoon },
                new() { Name = "Oliver", Age = 3, Color = "Black", Volume = 6, Weight = 5.0, Breed = BreedType.Persian },
            };

            cats.Sort((cat1, cat2) => cat1.Weight.CompareTo(cat2.Weight));
            foreach (var cat in cats)
            {
                Console.WriteLine($"{cat.Name} has a weight of {cat.Weight}");
            }

            Console.WriteLine(new string('-', 50));

            
            cats.Sort(new CatsComparerByDescending());

            foreach (var cat in cats)
            {
                Console.WriteLine($"{cat.Name} has a weight of {cat.Weight}");
            }

            Console.WriteLine(new string('-', 50));

            var sortedCats = cats
                               .Where(c => c.Breed == BreedType.Persian)
                               .OrderBy(c => c.Weight)
                               .ThenBy(c => c.Age)
                               .ToDictionary(c => c.Name, c => c);

            foreach (var cat in sortedCats.Values)
            {
                cat.Info();
                cat.Play();
                cat.Sleep();
            }

            Cat myCat = sortedCats["Luna"];
            myCat.Info();
        }

        private class CatsComparerByDescending : IComparer<Cat>
        {
            public int Compare(Cat? x, Cat? y)
            {
                if (x == null && y == null) return 0;

                if (x == null) return -1;

                if (y == null) return 1;

                return Math.Sign(y.Weight - x.Weight);
            }
        }
    }
}