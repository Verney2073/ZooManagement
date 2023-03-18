using ZooManagement.Models;
namespace ZooManagement.Response
{
    public class AnimalResponse
    {
        private readonly Animal _animal;

        public AnimalResponse(Animal animal)
        {
            _animal = animal;
        }
            public int Id => _animal.Id;
        public string Name => _animal.Name;
        public int speciesId => _animal.speciesId;

        public string sex => _animal.Sex;
        public DateTime DateOfBirth => _animal.DateOfBirth;
        public DateTime DateAcquired => _animal.DateAcquiredByZoo;

    }
}