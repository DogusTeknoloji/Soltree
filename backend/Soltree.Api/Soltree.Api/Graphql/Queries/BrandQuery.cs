using Soltree.Api.Data;
using Soltree.Api.Data.Entities;

namespace Soltree.Api.Graphql.Queries
{
    [ExtendObjectType("Query")]
    public class BrandQuery
    {
        [UseOffsetPaging]
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IQueryable<Brand> GetBrands([Service] AppDbContext context)
        {
            return context.Brands.AsQueryable();
        }
    }
}
