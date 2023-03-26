using Microsoft.EntityFrameworkCore;

namespace DotNetApi.Models
{
    public class PoetryDBContext: DbContext
    {
        public PoetryDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Poetry> Poetries { get; set; }
        public DbSet<Poet> Poets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Set some default data 
            modelBuilder.Entity<Poet>().HasData(
                new Poet()
                {
                    Name = "Hafez",
                    BirthDay = new DateTime(1355, 1, 1),
                    Id = 1
                }, new Poet()
                {
                    Name = "Molana",
                    BirthDay = new DateTime(1207, 9, 30),
                    Id = 2
                });

            modelBuilder.Entity<Poetry>().HasData(
                new Poetry()
                {
                    Name = "Masnavi manavi",
                    PoetId = 2,
                    Description = "مثنوی معنوی",
                    Id = 1
                });
        }
    }
}
