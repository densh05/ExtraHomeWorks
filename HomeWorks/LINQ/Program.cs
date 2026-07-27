using LINQ;

class Program
{
    static List<Cat> GetOldBlackMansCats(IEnumerable<Cat> cats)
    {
        return cats
            .Where(c => c.Age > 10 && c.Color == Color.Black && c.Sex == SexType.Male)
            .ToList();
    }

    static List<Cat> GetYoungCats(IEnumerable<Cat> cats)
    {
        return cats
            .Where(c => c.Age < 10 && (c.Breed == Breed.Persian || c.Weight < 10))
            .OrderBy(c => c.Age)
            .ThenBy(c => c.Weight)
            .ToList();
    }

    static List<dynamic> GetCatsCost(IEnumerable<Cat> cats, decimal maxPrice)
    {
        return cats
            .Where(c => c.Price <= maxPrice)
            .OrderByDescending(c => c.Age)
            .Select(c => new
            { 
                Name = c.Name,
                Weight = c.Weight,
                Price = c.Price,
                Age = c.Age
            })
            .Cast<dynamic>()
            .ToList();
    }

    //static List<IGrouping<Breed, Cat>> GetCatsGroupedByBreed(IEnumerable<Cat> breedGroup)
    //{
    //    return breedGroup.GroupBy(c => c.Breed).ToList();
    //}

    static List<dynamic> GetCatsGroupedByColorAndBreed(IEnumerable<Cat> colorGroup)
    {
        return colorGroup
            .GroupBy(c => new
        {
            c.Color,
            c.Breed
        })
            .Select(g => new
            {
                Color = g.Key.Color,
                Breed = g.Key.Breed,
                Cats = g.ToList()
            })
            .Cast<dynamic>()
            .ToList();
    }

    static (int Max, int Min, decimal Average) GetAllInformation(IEnumerable<Cat> cats)
    {
        int maxAge = cats.Max(c => c.Age);
        int minWeight = cats.Min(c => c.Weight);
        decimal averagePrice = cats.Average(c => c.Price);
        return (maxAge, minWeight, averagePrice);
    }

    static Dictionary<string, int> GetCatsCountByBreed(IEnumerable<Cat> cats)
    {
        return cats
            .GroupBy(c => c.Breed)
            .OrderBy(group => group.Key)
            .ToDictionary(g => g.Key.ToString(), g => g.Count());
    }

    static void Main()
    {
        var cats = new List<Cat>
        {
            new()
            {
                Id = 1,
                Name = "Maluyk",
                Weight = 10,
                Color = Color.White,
                Breed = Breed.Persian,
                Price = 100,
                Sex = SexType.Female,
                Age = 2
            },
            new()
            {
                Id = 2,
                Name = "Murka",
                Weight = 12,
                Color = Color.Black,
                Breed = Breed.MaineCoon,
                Price = 200,
                Sex = SexType.Female,
                Age = 7
            },
            new()
            {
                Id = 3,
                Name = "Barsik",
                Weight = 8,
                Color = Color.Gray,
                Breed = Breed.Ragdoll,
                Price = 90,
                Sex = SexType.Male,
                Age = 13
            },
            new()
            {
                Id = 4,
                Name = "Vaska",
                Weight = 9,
                Color = Color.Black,
                Breed = Breed.Persian,
                Price = 120,
                Sex = SexType.Male,
                Age = 10
            },
            new()
            {
                Id = 5,
                Name = "Bonia",
                Weight = 11,
                Color = Color.White,
                Breed = Breed.MaineCoon,
                Price = 180,
                Sex = SexType.Female,
                Age= 3
            },
            new()
            {
                Id = 6,
                Name = "Masik",
                Weight = 7,
                Color = Color.Gray,
                Breed = Breed.Ragdoll,
                Price = 60,
                Sex = SexType.Male,
                Age = 9
            },
            new()
            {
                Id = 7,
                Name = "Ron",
                Weight = 13,
                Color = Color.Black,
                Breed = Breed.MaineCoon,
                Price = 220,
                Sex = SexType.Female,
                Age = 10
             },
            new()
            {
                Id = 8,
                Name = "Luna",
                Weight = 14,
                Color = Color.White,
                Breed = Breed.Persian,
                Price = 130,
                Sex = SexType.Female,
                Age = 4
            },
            new()
            {
                Id = 9,
                Name = "Simba",
                Weight = 15,
                Color = Color.Gray,
                Breed = Breed.Ragdoll,
                Price = 70,
                Sex = SexType.Male,
                Age = 3
            },
            new()
            {
                Id = 10,
                Name = "Milo",
                Weight = 16,
                Color = Color.Black,
                Breed = Breed.MaineCoon,
                Price = 190,
                Sex = SexType.Male,
                Age = 14
            }

        };

        var adultCats = GetOldBlackMansCats(cats);
        adultCats.ForEach(c => Console.WriteLine($"Name: {c.Name}, Age: {c.Age}, Sex: {c.Sex}, Color: {c.Color}"));

        Console.WriteLine(new string('-', 50));

        var youngCats = GetYoungCats(cats);
        youngCats.ForEach(c => Console.WriteLine($"Name: {c.Name}, Age: {c.Age}, Breed: {c.Breed}, Weight: {c.Weight}"));

        Console.WriteLine(new string('-', 50));

        var priceCats = GetCatsCost(cats, 100);
        priceCats.ForEach(c => Console.WriteLine($"Name: {c.Name}, Age: {c.Age}, Weight: {c.Weight}, Price: {c.Price}"));

        Console.WriteLine(new string('-', 50));

        //var groupsCats = GetCatsGroupedByBreed(cats);
        //foreach (var group in groupsCats)
        //{
        //    Console.WriteLine($"Breed: {group.Key}");
        //    foreach (var cat in group)
        //    {
        //        Console.WriteLine($"  Name: {cat.Name}, Age: {cat.Age}");
        //    }
        //    Console.WriteLine(new string('-', 50));
        //}

        var colorGroups = GetCatsGroupedByColorAndBreed(cats);
        foreach (var group in colorGroups)
        {
            Console.WriteLine($"Color: {group.Color}");
            Console.WriteLine($"Breed: {group.Breed}");
            foreach (var cat in group.Cats)
            {
                Console.WriteLine($"  Name: {cat.Name}, Age: {cat.Age}");
            }
            Console.WriteLine(new string('-', 50));
        }

        var info = GetAllInformation(cats);
        Console.WriteLine($"Max Age: {info.Max}");
        Console.WriteLine($"Min Weight: {info.Min}");
        Console.WriteLine($"Average Price: {info.Average}");

        Console.WriteLine(new string('-', 50));

        var catsCountByBreed = GetCatsCountByBreed(cats);
        foreach (var item in catsCountByBreed)
        {
            Console.WriteLine($"Breed: {item.Key}, Count: {item.Value}");
        }
    }
}
