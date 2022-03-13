using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class GeneralContext : DbContext
    {
        public GeneralContext(DbContextOptions<GeneralContext> options)
            : base(options)
        {
        }

        public DbSet<User> user { get; set; }
        public DbSet<Person> Person {get; set;}
        public DbSet<City> City {get; set;}
    }
}