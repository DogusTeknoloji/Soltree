using Soltree.Api.Data;
using Soltree.Api.Data.Dtos;
using Soltree.Api.Data.Dtos.Solution;

namespace Soltree.Api.Graphql.Mutations
{
    public class SolutionMutation
    {
        public InsertResponse InsertSolution(SolutionInsertRequest request, [Service] AppDbContext context)
        {
            var respone = new InsertResponse();
            var solution = new Data.Etities.Solution(request.Title, request.Description);

            context.Solutions.Add(solution);
            context.SaveChanges();

            respone.Id = solution.Id;

            return respone;
        }

        public bool UpdateSolution(SolutionUpdateRequest request, [Service] AppDbContext context)
        {
            var solution = context.Solutions.SingleOrDefault(m => m.Id == request.Id);

            if (solution != null)
            {
                solution.Title = request.Title;
                solution.Description = request.Desc;

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
