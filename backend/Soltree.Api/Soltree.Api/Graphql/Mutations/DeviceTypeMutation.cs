using Soltree.Api.Data;
using Soltree.Api.Data.Dtos;
using Soltree.Api.Data.Dtos.Type;
using Soltree.Api.Data.Etities;

namespace Soltree.Api.Graphql.Mutations
{
    [ExtendObjectType("Mutation")]
    public class DeviceTypeMutation
    {
        public InsertResponse InsertDeviceType(DeviceTypeInsertRequest request, [Service] AppDbContext context)
        {
            var respone = new InsertResponse();
            var type = new DeviceType()
            {
                Name = request.Name,
                Image = request.Image
            };

            context.DeviceTypes.Add(type);
            context.SaveChanges();

            respone.Id = type.Id;

            return respone;
        }

        public bool UpdateDeviceType(DeviceTypeUpdateRequest request, [Service] AppDbContext context)
        {
            var type = context.DeviceTypes.SingleOrDefault(m => m.Id == request.Id);

            if (type != null)
            {
                type.Name = request.Name;
                type.Image = request.Image;

                context.SaveChanges();

                return true;
            }

            return false;
        }

        public bool DeleteDeviceType(Guid id, [Service] AppDbContext context)
        {
            var type = context.DeviceTypes.SingleOrDefault(m => m.Id == id);

            if (type != null)
            {
                context.Remove(type);
                context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
