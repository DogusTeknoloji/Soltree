using Microsoft.EntityFrameworkCore;
using Soltree.Api.Data.Etities;

namespace Soltree.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<Brand> Brands => Set<Brand>();
        public DbSet<Etities.Type> Types => Set<Etities.Type>();
        public DbSet<Model> Models => Set<Model>();
        public DbSet<Symptom> Symptoms => Set<Symptom>();
        public DbSet<SymptomCategory> SymptomCategories => Set<SymptomCategory>();
        public DbSet<Solution> Solutions => Set<Solution>();

    }
}
