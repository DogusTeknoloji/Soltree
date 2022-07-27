using Soltree.Api.Data;
using Soltree.Api.Data.Etities;

namespace Soltree.Api.Graphql.Queries
{
    [ExtendObjectType("Query")]
    public class ModelQuery
    {
        [UseOffsetPaging]
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IQueryable<Model> GetModels([Service] AppDbContext context)
        {
            return context.Models.AsQueryable();
        }

        
    }
}
