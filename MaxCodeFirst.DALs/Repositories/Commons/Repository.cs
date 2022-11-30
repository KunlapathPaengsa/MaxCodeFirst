using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MaxCodeFirst.DALs.Repositories.Commons
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        private readonly IDbContext dbContext;

        public Repository(IDbContext dbContext)
        {
            _dbSet = dbContext.Set<T>();
            this.dbContext = dbContext;
        }

        public async ValueTask AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public T First()
        {
            return _dbSet.First();
        }

        public Task<T> FirstAsync()
        {
            return _dbSet.FirstAsync();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.AsQueryable().ToListAsync();
        }
    }
}
