using Soltree.Api.Data;

namespace Soltree.Api.Graphql.Queries
{
    public class Query
    {
        [UseOffsetPaging]
        [UseSorting]
        [UseFiltering]
        public void Search(string name, [Service] AppDbContext context)
        {

        }
        [GraphQLDeprecated("This query is deprecated.")]
        public string Instructions => "Hello World";
    }
}
