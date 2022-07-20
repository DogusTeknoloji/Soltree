using Soltree.Api.Data.Etities;

namespace Soltree.Api.Data
{
    public class Query
    {
        public IQueryable<Brand> GetBrands([Service] AppDbContext context)
        {
            return context.Brands;
        }
    }
}
