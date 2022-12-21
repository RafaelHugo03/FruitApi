using Microsoft.EntityFrameworkCore;
using src.Data.Mappings;
using src.Entities;

namespace src.Data
{
    public class FruitDataContext : DbContext
    {
        public FruitDataContext(DbContextOptions<FruitDataContext> options) : base(options)
        {

        }

        public DbSet<Fruit> Fruits { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FruitMap());
        }
    }
}