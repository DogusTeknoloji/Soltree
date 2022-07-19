namespace Soltree.Api.Data.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        Task<List<T>> GetAllAsync();

        T? Get(Guid id);
        ValueTask<T?> GetAsync(Guid id);
    }
}
