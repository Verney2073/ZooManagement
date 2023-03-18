using System.Collections.Generic;

namespace ZooManagement.Data
{
    public static class NameGenerator
    {
        private static readonly Random random = new Random();

        private static readonly IList<string> Names = new List<string>
        {
            "Buddy",
            "Max",
            "Luna",
            "Charlie",
            "Lucy",
            "Daisy",
            "Bailey",
            "Rocky",
            "Sadie",
            "Molly",
            "Jack",
            "Milo",
            "Cooper",
            "Oliver",
            "Chloe",
            "Teddy",
            "Bella",
            "Leo",
            "Ruby",
            "Rosie",
            "Sam",
            "Zoe",
            "Lilly",
            "Oscar",
            "Simba",
            "Toby",
            "Pepper",
            "Frankie",
            "Gus",
            "Sasha",
            "Harley",
            "Zeus",
            "Sunny",
            "Nala",
            "Rex",
            "Snickers",
            "Thor",
            "Shadow",
            "Jasper",
            "Loki",
            "Coco",
            "Koda",
            "Benji",
            "Rusty",
            "Maximus",
            "Nova",
            "Apollo",
            "Blue",
            "Diesel",
            "Ella",
            "Roxy",
            "Marley",
            "Tucker",
            "Winston",
            "Ginger",
            "Ruby",
            "Ruby",
            "Bentley",
            "Millie",
            "Phoebe",
            "Remi",
            "Bailey",
            "Hazel",
            "Riley",
            "Stella",
            "Bandit",
            "Belle",
            "Bruno",
            "Charlie",
            "Jax",
            "Kobe",
            "Leo",
            "Lulu",
            "Murphy",
            "Piper",
            "Ranger",
            "Sassy",
            "Willow"
            };
        public static string GetName()
        {
            string randomName = Names[random.Next(Names.Count)];
            return randomName;
        }
    }
}
