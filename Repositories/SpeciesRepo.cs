using Microsoft.EntityFrameworkCore;
using ZooManagement.Models;

namespace ZooManagement.Repositories
{
    public interface ISpeciesRepo
    {
        Species GetById(int id);

        DbSet<Species> GetAllSpecies();
        public class SpeciesRepo : ISpeciesRepo
        {
            private readonly ZooManagementContext _context;
            public SpeciesRepo(ZooManagementContext context)
            {
                _context = context;
            }
            public Species GetById(int id)
            {
                return _context.Species
                    .Single(species => species.Id == id);
            }

            public DbSet<Species> GetAllSpecies()
            {
                return _context.Species;
            }
        }
    }
}