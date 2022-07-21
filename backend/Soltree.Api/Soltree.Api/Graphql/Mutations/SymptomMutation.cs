using Soltree.Api.Data;
using Soltree.Api.Data.Dtos;
using Soltree.Api.Data.Dtos.Symptom;

namespace Soltree.Api.Graphql.Mutations
{
    public class SymptomMutation
    {
        public InsertResponse InsertSymptom(SymptomInsertRequest request, [Service] AppDbContext context)
        {
            var respone = new InsertResponse();
            var symptom = new Data.Etities.Symptom(request.Name, request.CategoryId);

            context.Symptoms.Add(symptom);
            context.SaveChanges();

            respone.Id = symptom.Id;

            return respone;
        }

        public bool UpdateSymptom(SymptomUpdateRequest request, [Service] AppDbContext context)
        {
            var symptom = context.Symptoms.SingleOrDefault(m => m.Id == request.Id);

            if (symptom != null)
            {
                symptom.Name = request.Name;
                symptom.CategoryId = request.CategoryId;

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
