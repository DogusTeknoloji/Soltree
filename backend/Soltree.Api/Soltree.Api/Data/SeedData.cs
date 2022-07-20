using Microsoft.EntityFrameworkCore;

namespace Soltree.Api.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var dbContext = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

            PopulateTestData(dbContext);
        }

        public static void PopulateTestData(AppDbContext dbContext)
        {
            if (dbContext.Brands.Any())
            {
                return;
            }

            for (int i = 0; i < 10; i++)
            {
                dbContext.Brands.Add(new Etities.Brand($"Brand - {i + 1}")
                {
                    Id = Guid.NewGuid()
                });
            }

            dbContext.SaveChanges();
        }
    }
}
