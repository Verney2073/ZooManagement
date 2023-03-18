using ZooManagement.Models;
using static ZooManagement.Models.Species;

namespace ZooManagement.Data
{
    public static class SpeciesList
    {
        private static readonly Random random = new Random();
        private static readonly List<string[]> animalList = new List<string[]>
{
    new string[] {"Giraffe", "mammal"},
    new string[] {"Komodo Dragon", "reptile"},
    new string[] {"Eagle", "bird"},
    new string[] {"Butterfly", "insect"},
    new string[] {"Salmon", "fish"},
    new string[] {"Octopus", "invertebrate"},
    new string[] {"Lion", "mammal"},
    new string[] {"Crocodile", "reptile"},
    new string[] {"Penguin", "bird"},
    new string[] {"Tarantula", "invertebrate"},
    new string[] {"Gorilla", "mammal"},
    new string[] {"Iguana", "reptile"},
    new string[] {"Parrot", "bird"},
    new string[] {"Ant", "insect"},
    new string[] {"Swordfish", "fish"},
    new string[] {"Starfish", "invertebrate"},
    new string[] {"Kangaroo", "mammal"},
    new string[] {"Turtle", "reptile"},
    new string[] {"Pigeon", "bird"},
    new string[] {"Spider", "invertebrate"}
};

        public static IEnumerable<Species> GetSpecies()
        {
            return Enumerable.Range(0, animalList.Count).Select(CreateSpecies);
        }

        public static int GetRandomSpeciesId()
        {
            //As the ID is actually created using the index value, from a list of 20 species the IDs will be 0-19. So we exclude the value equal to animalList.count
            return random.Next(animalList.Count);

        }
        private static Species CreateSpecies(int index)
        {
            return new Species
            {
                SpeciesName = animalList[index][0],
                Classification = (Classifications)Enum.Parse(typeof(Classifications), animalList[index][1])
            };
        }
    }
}