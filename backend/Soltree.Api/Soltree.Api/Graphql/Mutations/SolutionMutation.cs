using Soltree.Api.Data;
using Soltree.Api.Data.Dtos;
using Soltree.Api.Data.Dtos.Solution;
using Soltree.Api.Data.Entities;

namespace Soltree.Api.Graphql.Mutations
{
    [ExtendObjectType("Mutation")]
    public class SolutionMutation
    {
        public InsertResponse InsertSolution(SolutionInsertRequest request, [Service] AppDbContext context)
        {
            var response = new InsertResponse();
            var solution = new Solution()
            {
                Title = request.Title,
                Description = request.Description,
                SymptomId = request.SymptomId
            };

            context.Solutions.Add(solution);
            context.SaveChanges();

            response.Id = solution.Id;

            return response;
        }

        public bool UpdateSolution(SolutionUpdateRequest request, [Service] AppDbContext context)
        {
            var solution = context.Solutions.SingleOrDefault(m => m.Id == request.Id);

            if (solution != null)
            {
                solution.Title = request.Title;
                solution.Description = request.Description;
                solution.SymptomId = request.SymptomId;

                context.SaveChanges();

                return true;
            }

            return false;
        }

        public bool DeleteSolution(Guid id, [Service] AppDbContext context)
        {
            var solution = context.Solutions.SingleOrDefault(m => m.Id == id);

            if (solution != null)
            {
                context.Remove(solution);
                context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
