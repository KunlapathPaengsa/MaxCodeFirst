using MaxCodeFirst.Models.TablesAndEntities;

namespace MaxCodeFirst.Service.Commands
{
    public interface IStudentCommandService
    {
        Task<int> AddStudentAsync(Student student);
    }
}