using System.Collections.Generic;
using System.Linq;
using ZooManagement.Models;

namespace ZooManagement.Data
{
    public static class SampleAnimals
    {
        public static int NumberOfAnimals => 100;

        public static IEnumerable<Animal> GetAnimals()
        {
            return Enumerable.Range(0, NumberOfAnimals).Select(CreateAnimal);
        }

        private static Animal CreateAnimal(int index)
        {
            DateTime dateofbirth = DateGenerator.GetDateofBirth();
            return new Animal
            {

                //hardcoding the speciesID generator here which is not ideal
                speciesId = SpeciesList.GetRandomSpeciesId(),
                Name = NameGenerator.GetName(),
                Sex = SexGenerator.GetRandomSex(),
                DateOfBirth = dateofbirth,
                DateAcquiredByZoo = DateGenerator.GetDateAcquiredByZoo(dateofbirth)
            };
        }
    }
}

