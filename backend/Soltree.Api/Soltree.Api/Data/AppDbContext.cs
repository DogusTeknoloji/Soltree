using Microsoft.EntityFrameworkCore;
using Soltree.Api.Data.Entities;

namespace Soltree.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<Brand> Brands => Set<Brand>();
        public DbSet<DeviceType> DeviceTypes => Set<DeviceType>();
        public DbSet<Model> Models => Set<Model>();
        public DbSet<Symptom> Symptoms => Set<Symptom>();
        public DbSet<SymptomCategory> SymptomCategories => Set<SymptomCategory>();
        public DbSet<Solution> Solutions => Set<Solution>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

        }
    }
}
