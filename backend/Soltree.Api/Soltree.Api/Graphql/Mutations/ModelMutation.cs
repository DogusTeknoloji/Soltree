using Soltree.Api.Data;
using Soltree.Api.Data.Dtos;
using Soltree.Api.Data.Dtos.Model;

namespace Soltree.Api.Graphql.Mutations
{
    public class ModelMutation
    {
        public InsertResponse InsertModel(ModelInsertRequest request, [Service] AppDbContext context)
        {
            var respone = new InsertResponse();
            var model = new Data.Etities.Model(request.Name,request.BrandId,request.TypeId);

            context.Models.Add(model);
            context.SaveChanges();

            respone.Id = model.Id;

            return respone;

        }

        public bool UpdateBrandModel(ModelUpdateRequest request, [Service] AppDbContext context)
        {
            var model = context.Models.SingleOrDefault(m => m.Id == request.Id);

            if (model != null)
            {
                model.Name = request.Name;

                context.SaveChanges();

                return true;
            }

            return false;
        }

        public bool DeleteModel(Guid id, [Service] AppDbContext context)
        {
            var model = context.Models.SingleOrDefault(m => m.Id == id);

            if (model != null)
            {
                context.Remove(model);
                context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
