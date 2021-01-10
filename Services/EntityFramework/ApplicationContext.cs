using Korelskiy.CityGuide.Models.Guide;
using Microsoft.EntityFrameworkCore;

namespace Korelskiy.CityGuide.Services.EntityFramework
{
    class ApplicationContext : DbContext
    {
        public DbSet<City> Cities{ get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
    }
}
