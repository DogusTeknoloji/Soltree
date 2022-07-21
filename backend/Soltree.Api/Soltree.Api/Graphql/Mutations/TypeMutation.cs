using Soltree.Api.Data;
using Soltree.Api.Data.Dtos;
using Soltree.Api.Data.Dtos.Type;

namespace Soltree.Api.Graphql.Mutations
{
    public class TypeMutation
    {
        public InsertResponse InsertType(TypeInsertRequest request, [Service] AppDbContext context)
        {
            var respone = new InsertResponse();
            var type = new Data.Etities.Type(request.Name);

            context.Types.Add(type);
            context.SaveChanges();

            respone.Id = type.Id;

            return respone;
        }

        public bool UpdateType(TypeUpdateRequest request, [Service] AppDbContext context)
        {
            var type = context.Types.SingleOrDefault(m => m.Id == request.Id);

            if (type != null)
            {
                type.Name = request.Name;

                context.SaveChanges();

                return true;
            }

            return false;
        }

        public bool DeleteType(Guid id, [Service] AppDbContext context)
        {
            var type = context.Types.SingleOrDefault(m => m.Id == id);

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
