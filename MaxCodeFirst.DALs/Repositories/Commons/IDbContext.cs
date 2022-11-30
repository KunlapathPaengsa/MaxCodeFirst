using Microsoft.EntityFrameworkCore;

namespace MaxCodeFirst.DALs.Repositories.Commons
{
    public interface IDbContext : IDisposable
    {
        DbSet<T> Set<T>() where T : class;

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}