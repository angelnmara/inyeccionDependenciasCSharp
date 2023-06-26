using DB.Modelo;
using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class HomeIncContext : DbContext
    {
        public HomeIncContext(DbContextOptions<HomeIncContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Warranty> Warranties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Warranty>().ToTable("Warranty");
        }
    }
}