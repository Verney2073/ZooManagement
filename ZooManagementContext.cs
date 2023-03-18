// using ZooManagement.Models;
//Create this soon
using Microsoft.EntityFrameworkCore;
using ZooManagement.Models;
using Microsoft.Extensions.DependencyInjection;


namespace ZooManagement
{
    public class ZooManagementContext : DbContext
    {
        public ZooManagementContext(DbContextOptions<ZooManagementContext> options) : base(options) { }

        // Put all the tables you want in your database here
        public DbSet<Species> Species { get; set; }

        public DbSet<Animal> Animals {get;set;}

    }
}