using MaxCodeFirst.DALs.Repositories.Commons;
using MaxCodeFirst.Models.TablesAndEntities;

namespace MaxCodeFirst.DALs.Repositories.Commands
{
    public class StudentCommandRepository : Repository<Student>, IStudentCommandRepository
    {
        public StudentCommandRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
