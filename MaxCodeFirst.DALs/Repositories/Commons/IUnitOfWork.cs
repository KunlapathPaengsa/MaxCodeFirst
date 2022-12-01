namespace MaxCodeFirst.DALs.Repositories.Commons
{
    public interface IUnitOfWork
    {

        IRepository<T> GetRepository<T>() where T : class;

        Task<int> SaveChangesAsync();
    }
}