using MaxCodeFirst.Models.TablesAndEntities;
using MaxCodeFirst.Service.Commands;
using Microsoft.AspNetCore.Mvc;

namespace MaxCodeFirst.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentCommandService _service;

        public StudentController(IStudentCommandService service)
        {
            _service = service;
        }

        [HttpGet("GetAllStudent")]
        public IEnumerable<Student> Get()
        {
            return Array.Empty<Student>();
        }

        [HttpPost("AddStudent")]
        public async Task<IActionResult> AddStudent([FromBody] Student name) 
        {
            var addStudent = new Student { Name = "max" , Description = "test" };
            await _service.AddStudentAsync(addStudent);
            return Ok(addStudent);
        }
    }
}
