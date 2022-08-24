using Soltree.Api.Data;
using Soltree.Api.Data.Dtos;
using Soltree.Api.Data.Dtos.Symptom;
using Soltree.Api.Data.Entities;

namespace Soltree.Api.Graphql.Mutations
{
    [ExtendObjectType("Mutation")]
    public class SymptomMutation
    {
        public InsertResponse InsertSymptom(SymptomInsertRequest request, [Service] AppDbContext context)
        {
            var response = new InsertResponse();
            var symptom = new Symptom()
            {
                Name = request.Name,
                SymptomCategoryId = request.SymptomCategoryId
            };

            context.Symptoms.Add(symptom);
            context.SaveChanges();

            response.Id = symptom.Id;

            return response;
        }

        public bool UpdateSymptom(SymptomUpdateRequest request, [Service] AppDbContext context)
        {
            var symptom = context.Symptoms.SingleOrDefault(m => m.Id == request.Id);

            if (symptom != null)
            {
                symptom.Name = request.Name;
                symptom.SymptomCategoryId = request.SymptomCategoryId;

                context.SaveChanges();

                return true;
            }

            return false;
        }

        public bool DeleteSymptom(Guid id, [Service] AppDbContext context)
        {
            var symptom = context.Symptoms.SingleOrDefault(m => m.Id == id);

            if (symptom != null)
            {
                context.Remove(symptom);
                context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
