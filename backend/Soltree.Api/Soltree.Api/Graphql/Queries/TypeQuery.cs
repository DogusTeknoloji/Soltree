using Soltree.Api.Data;
using Soltree.Api.Data.Etities;

namespace Soltree.Api.Graphql.Queries
{
    [ExtendObjectType((typeof(Query)))]
    public class TypeQuery
    {
        [UseOffsetPaging]
        [UseSorting]
        [UseFiltering]
        public IQueryable<Data.Etities.Type> GetTypes([Service] AppDbContext context)
        {
            return context.Types;
        }
    }
}
