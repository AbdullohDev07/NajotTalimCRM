using FileAPILesson.Application.Services.StudentServices;
using FileAPILesson.Domain.Entities.DTOs;
using FileAPILesson.Domain.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileAPILesson.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentCRUD : ControllerBase
    {
        private readonly IStudentService _stud;
        public StudentCRUD(IStudentService stud)
        {
            _stud = stud;
        }

        [HttpGet]
        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _stud.GetAllStudents();
        }
        [HttpGet]
        public async Task<Student> GetStudentById(int id)
        {
            return await _stud.GetStudent(id);
        }
        [HttpPost]
        public async Task<string> CreateStudent([FromForm] StudentDTO st)
        {
            return await _stud.CreateStudent(st);
        }
        [HttpPut]
        public async Task<string> UpdateStudent(int id, [FromForm] StudentDTO st)
        {
            return await _stud.UpdateStudent(id, st);
        }
        [HttpDelete]
        public async Task<string> DeleteStudent(int id)
        {
            return await _stud.DeleteStudent(id);
        }
    }
}
