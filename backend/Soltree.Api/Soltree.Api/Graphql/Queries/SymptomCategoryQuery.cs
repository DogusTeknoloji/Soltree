using Soltree.Api.Data;
using Soltree.Api.Data.Etities;

namespace Soltree.Api.Graphql.Queries
{
    [ExtendObjectType((typeof(Query)))]
    public class SymptomCategoryQuery
    {
        [UseOffsetPaging]
        [UseSorting]
        [UseFiltering]
        public IQueryable<SymptomCategory> GetSymptomCategorys([Service] AppDbContext context)
        {
            return context.SymptomCategories;
        }
    }
}
