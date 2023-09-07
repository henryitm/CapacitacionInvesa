using CapacitacionInvesa.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace CapacitacionInvesa.Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<State>().HasIndex(s => new { s.CountryId, s.Name }).IsUnique();
            modelBuilder.Entity<City>().HasIndex(c => new { c.StateId, c.Name }).IsUnique();

        }
    }
}
