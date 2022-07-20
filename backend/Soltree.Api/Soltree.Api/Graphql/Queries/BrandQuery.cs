using Soltree.Api.Data;
using Soltree.Api.Data.Etities;

namespace Soltree.Api.Graphql.Queries
{
    public class BrandQuery
    {
        [UseOffsetPaging]
        [UseSorting]
        [UseFiltering]
        public IQueryable<Brand> GetBrands([Service] AppDbContext context)
        {
            return context.Brands;
        }
    }
}
