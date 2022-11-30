using System.Linq.Expressions;

namespace MaxCodeFirst.DALs.Repositories.Commons
{
    public interface IRepository<T> where T : class
    {
        ValueTask AddAsync(T entity);

        void Remove(T entity);

        void Update(T entity);

        T First();

        Task<T> FirstAsync();

        Task<IEnumerable<T>> GetAllAsync();

        IQueryable<T> Where(Expression<Func<T, bool>> expression);
    }
}