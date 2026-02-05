using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Services;

namespace StudentManagementAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;
        public StudentController(IStudentService service)   
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var student = _service.GetById(id);
            if (student == null)
                return NotFound();
            return Ok(student);
        }
        [HttpPost]
        public IActionResult Add(Student student)
        {
            var updated = _service.Add(student);
        }
    }
}
