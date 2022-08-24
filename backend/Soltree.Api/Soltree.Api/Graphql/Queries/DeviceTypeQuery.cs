using Soltree.Api.Data;
using Soltree.Api.Data.Entities;

namespace Soltree.Api.Graphql.Queries
{
    [ExtendObjectType("Query")]
    public class DeviceTypeQuery
    {
        [UseOffsetPaging]
        [UseSorting]
        [UseFiltering]
        public IQueryable<DeviceType> GetDeviceTypes([Service] AppDbContext context)
        {
            return context.DeviceTypes.AsQueryable();
        }
    }
}
