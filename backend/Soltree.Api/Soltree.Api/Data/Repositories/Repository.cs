using Microsoft.EntityFrameworkCore;
using Soltree.Api.Data.Etities;

namespace Soltree.Api.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _dbContext;

        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T? Get(Guid id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public Task<List<T>> GetAllAsync()
        {
            return _dbContext.Set<T>().ToListAsync();
        }

        public ValueTask<T?> GetAsync(Guid id)
        {
            return _dbContext.Set<T>().FindAsync(id);
        }
    }
}
