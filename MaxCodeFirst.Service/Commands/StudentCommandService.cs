using MaxCodeFirst.DALs.Repositories.Commands;
using MaxCodeFirst.DALs.Repositories.Commons;
using MaxCodeFirst.Models.TablesAndEntities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCodeFirst.Service.Commands
{
    public class StudentCommandService : IStudentCommandService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStudentCommandRepository _repository;

        public StudentCommandService(IUnitOfWork unitOfWork, IStudentCommandRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<int> AddStudentAsync(Student student)
        {
            var newStudent = new Student
            {
                Name = "Max",
                Description = "test"
            };
            await _repository.AddAsync(newStudent);
            return await _unitOfWork.SaveChangesAsync();
        }
    }
}
