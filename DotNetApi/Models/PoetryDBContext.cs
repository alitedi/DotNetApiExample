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
        }
    }
}
