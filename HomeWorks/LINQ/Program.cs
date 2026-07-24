using LINQ;

class Program
{
    static List<Cat> GetOldBlackMansCats(IEnumerable<Cat> cats)
    {
        return cats
            .Where(c => c.Age > 10 && c.Color == ColorType.Black && c.Sex == SexType.Male)
            .ToList();
    }

    static List<Cat> GetYoungCats(IEnumerable<Cat> cats)
    {
        return cats
            .Where(c => c.Age < 10 && (c.Breed == BreedType.Persian || c.Weight < 10))
            .ToList();
    }

    static List<Cat> GetCatsMoney(IEnumerable<Cat> cats, decimal maxPrice)
    {
        return cats
            .Where(c => c.Price <= maxPrice)
            .ToList();
    }

    static List<IGrouping<BreedType, Cat>> GetCatsGroupedByBreed(IEnumerable<Cat> breedGroup)
    {
        return breedGroup.GroupBy(c => c.Breed).ToList();
    }

    static List<IGrouping<ColorType, Cat>> GetCatsGroupedByColor(IEnumerable<Cat> colorGroup)
    {
        return colorGroup.GroupBy(c => c.Color).ToList();
    }

    static void GetAllInformation(IEnumerable<Cat> cats)
    {
        int maxAge = cats.Max(c => c.Age);
        int minWeight = cats.Min(c => c.Weight);
        decimal averagePrice = cats.Average(c => c.Price);

        Console.WriteLine($"Max Age: {maxAge}");
        Console.WriteLine($"Min Weight: {minWeight}");
        Console.WriteLine($"Average Price: {averagePrice}");
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
                Color = ColorType.White,
                Breed = BreedType.Persian,
                Price = 100,
                Sex = SexType.Female,
                Age = 2
            },
            new()
            {
                Id = 2,
                Name = "Murka",
                Weight = 12,
                Color = ColorType.Black,
                Breed = BreedType.MaineCoon,
                Price = 200,
                Sex = SexType.Female,
                Age = 7
            },
            new()
            {
                Id = 3,
                Name = "Barsik",
                Weight = 8,
                Color = ColorType.Gray,
                Breed = BreedType.Ragdoll,
                Price = 90,
                Sex = SexType.Male,
                Age = 13
            },
            new()
            {
                Id = 4,
                Name = "Vaska",
                Weight = 9,
                Color = ColorType.Black,
                Breed = BreedType.Persian,
                Price = 120,
                Sex = SexType.Male,
                Age = 10
            },
            new()
            {
                Id = 5,
                Name = "Bonia",
                Weight = 11,
                Color = ColorType.White,
                Breed = BreedType.MaineCoon,
                Price = 180,
                Sex = SexType.Female,
                Age= 3
            },
            new()
            {
                Id = 6,
                Name = "Masik",
                Weight = 7,
                Color = ColorType.Gray,
                Breed = BreedType.Ragdoll,
                Price = 60,
                Sex = SexType.Male,
                Age = 9
            },
            new()
            {
                Id = 7,
                Name = "Ron",
                Weight = 13,
                Color = ColorType.Black,
                Breed = BreedType.MaineCoon,
                Price = 220,
                Sex = SexType.Female,
                Age = 10
             },
            new()
            {
                Id = 8,
                Name = "Luna",
                Weight = 14,
                Color = ColorType.White,
                Breed = BreedType.Persian,
                Price = 130,
                Sex = SexType.Female,
                Age = 4
            },
            new()
            {
                Id = 9,
                Name = "Simba",
                Weight = 15,
                Color = ColorType.Gray,
                Breed = BreedType.Ragdoll,
                Price = 70,
                Sex = SexType.Male,
                Age = 3
            },
            new()
            {
                Id = 10,
                Name = "Milo",
                Weight = 16,
                Color = ColorType.Black,
                Breed = BreedType.MaineCoon,
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

        var priceCats = GetCatsMoney(cats, 100);
        priceCats.ForEach(c => Console.WriteLine($"Name: {c.Name}, Age: {c.Age}, Weight: {c.Weight}, Price: {c.Price}"));

        Console.WriteLine(new string('-', 50));

        var groupsCats = GetCatsGroupedByBreed(cats);
        foreach (var group in groupsCats)
        {
            Console.WriteLine($"Breed: {group.Key}");
            foreach (var cat in group)
            {
                Console.WriteLine($"  Name: {cat.Name}, Age: {cat.Age}");
            }
            Console.WriteLine(new string('-', 50));
        }

        var colorGroups = GetCatsGroupedByColor(cats);
        foreach (var group in colorGroups)
        {
            Console.WriteLine($"Color: {group.Key}");
            foreach (var cat in group)
            {
                Console.WriteLine($"  Name: {cat.Name}, Age: {cat.Age}");
            }
            Console.WriteLine(new string('-', 50));
        }

        GetAllInformation(cats);

        Console.WriteLine(new string('-', 50));

        var catsCountByBreed = GetCatsCountByBreed(cats);
        foreach (var item in catsCountByBreed)
        {
            Console.WriteLine($"Breed: {item.Key}, Count: {item.Value}");
        }
    }
}
