using ZooManagement.Models;

namespace ZooManagement.Repositories
{
    public interface IAnimalsRepo
    {
        Animal GetById(int id);

        List<Animal> GetBySearch(string q);
        public class AnimalsRepo : IAnimalsRepo 
        {
            private readonly ZooManagementContext _context;
            public AnimalsRepo(ZooManagementContext context)
            {
                _context = context;
            }
               public Animal GetById(int id)
        {
            return _context.Animals
                .Single(animal => animal.Id == id);
        }

        public List<Animal> GetBySearch(string q)
        {
           var results = _context.Animals.Where(m => m.Name.Contains(q)).ToList();

           return results;

        } 

        }
    }
}