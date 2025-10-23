using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Application;
using System.Linq.Expressions;

namespace JomarHealthCare.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly IUnitOfWork dbContext;
        protected DbSet<T> EntitySet;
   
        public GenericRepository(IUnitOfWork dbContext)
        {
            this.dbContext = dbContext;
            EntitySet = dbContext.Set<T>();
        }

        public virtual async ValueTask<T> AddAsync(T entity)
        {
            var state = await EntitySet.AddAsync(entity);
            return state.Entity;
        }

        public virtual async ValueTask<T> AddAsync(T entity, CancellationToken cancellationToken)
        {
            var state = await EntitySet.AddAsync(entity, cancellationToken);
            return state.Entity;
        }
        public IQueryable<T> Get()
        {
            return EntitySet;
        }

        public virtual void Delete(T entity)
        {
            EntitySet.Remove(entity);
        }

        public async ValueTask<T?> GetByKeyAsync(object key, CancellationToken cancellationToken)
        {
            return await EntitySet.FindAsync(key, cancellationToken);
        }

        public virtual void Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return EntitySet.Where(predicate).AsQueryable<T>();
        }

        

        public Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return EntitySet.AnyAsync(predicate, cancellationToken);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            await EntitySet.AddRangeAsync(entities, cancellationToken);
        }
    }
}
