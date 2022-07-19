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
    }
}
