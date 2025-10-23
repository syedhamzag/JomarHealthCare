using System.Linq.Expressions;

namespace JomarHealthCare.Application.Repositories
{
    public interface IGenericRepository<T>
    {
        IQueryable<T> Get();
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        ValueTask<T?> GetByKeyAsync(object key, CancellationToken cancellationToken);
        ValueTask<T> AddAsync(T entity);
        ValueTask<T> AddAsync(T entity, CancellationToken cancellationToken);
        Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);
        void Update(T entity);
        void Delete(T entity);
        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);
    }
}
