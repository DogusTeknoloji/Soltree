using Soltree.Api.Data;
using Soltree.Api.Data.Dtos;
using Soltree.Api.Data.Dtos.Brand;

namespace Soltree.Api.Graphql.Mutations
{
    public class BrandMutation
    {
        public InsertResponse InsertBrand(BrandInsertRequest request, [Service] AppDbContext context)
        {
            var respone = new InsertResponse();
            var brand = new Data.Etities.Brand(request.Name);

            context.Brands.Add(brand);
            context.SaveChanges();

            respone.Id = brand.Id;

            return respone;
        }

        public bool UpdateBrand(BrandUpdateRequest request, [Service] AppDbContext context)
        {
            var brand = context.Brands.SingleOrDefault(m => m.Id == request.Id);

            if (brand != null)
            {
                brand.Name = request.Name;

                context.SaveChanges();

                return true;
            }

            return false;
        }

        public bool DeleteBrand(Guid id, [Service] AppDbContext context)
        {
            var brand = context.Brands.SingleOrDefault(m => m.Id == id);

            if (brand != null)
            {
                context.Remove(brand);
                context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
