using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLDemoApp.Models;
using Microsoft.AspNetCore.Http;
using SQLDemoApp.Data;
using SQLDemoApp.DTO;

namespace SQLDemoApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        

        [HttpGet("GetAll")]
        public async Task<IActionResult<Enumerable<StudentReadDto>>> GetAll()
        {
            var students = await _context.Students
                .Select(s => new StudentReadDto
                {
                    Id = s.Id,
                    FullName = s.FullName,
                    Email = s.Email,
                    Department = s.Department
                })
                .ToListAsync();

            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult<StudentReadDto>> GetById(int id)
        {
            var student = await _context.Students.FindAsync(id);
                
            if studnet == null
            {
                return NotFound();
            }

            var readDto = new StudentReadDto
            {
                Id = student.Id,
                Usn = student.Usn,
                FullName = student.FullName,
                Email = student.Email,
                Department = student.Department
            };
            return Ok(readDto);


        }
}
