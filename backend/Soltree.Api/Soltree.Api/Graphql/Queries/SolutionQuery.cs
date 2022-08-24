using Soltree.Api.Data;
using Soltree.Api.Data.Entities;

namespace Soltree.Api.Graphql.Queries
{
    [ExtendObjectType("Query")]
    public class SolutionQuery
    {
        [UseOffsetPaging]
        [UseSorting]
        [UseFiltering]
        public IQueryable<Solution> GetSolutions([Service] AppDbContext context)
        {
            return context.Solutions.AsQueryable();
        }
    }
}
