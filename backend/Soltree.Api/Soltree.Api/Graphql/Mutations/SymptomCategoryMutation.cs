using Soltree.Api.Data;
using Soltree.Api.Data.Dtos;
using Soltree.Api.Data.Dtos.SymptomCategory;
using Soltree.Api.Data.Etities;

namespace Soltree.Api.Graphql.Mutations
{
    [ExtendObjectType("Mutation")]
    public class SymptomCategoryMutation
    {
        public InsertResponse InsertSymptomCategory(SymptomCategoryInsertRequest request, [Service] AppDbContext context)
        {
            var respone = new InsertResponse();
            var symptomcategory = new SymptomCategory()
            {
                Name = request.Name,
                ModelId = request.ModelId
            };

            context.SymptomCategories.Add(symptomcategory);
            context.SaveChanges();

            respone.Id = symptomcategory.Id;

            return respone;
        }

        public bool UpdateSymptomCategory(SymptomCategoryUpdateRequest request, [Service] AppDbContext context)
        {
            var symptomcategory = context.SymptomCategories.SingleOrDefault(m => m.Id == request.Id);

            if (symptomcategory != null)
            {
                symptomcategory.Name = request.Name;
                symptomcategory.ModelId = request.ModelId;

                context.SaveChanges();

                return true;
            }

            return false;
        }

        public bool DeleteSymptomCategory(Guid id, [Service] AppDbContext context)
        {
            var symptomcategory = context.SymptomCategories.SingleOrDefault(m => m.Id == id);

            if (symptomcategory != null)
            {
                context.Remove(symptomcategory);
                context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
