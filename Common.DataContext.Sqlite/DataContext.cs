using Microsoft.EntityFrameworkCore;

namespace DinoWebAPI
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Dinosaur> Dinosaurs => Set<Dinosaur>();
    }
}