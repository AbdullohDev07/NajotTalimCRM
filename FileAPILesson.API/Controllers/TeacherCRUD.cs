using FileAPILesson.Application.Services.TeacherServices;
using FileAPILesson.Domain.Entities.DTOs;
using FileAPILesson.Domain.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileAPILesson.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeacherCRUD : ControllerBase
    {
        private readonly ITeacherService _teach;

        public TeacherCRUD(ITeacherService teach)
        {
            _teach = teach;
        }

        [HttpGet]
        public async Task<IEnumerable<Teacher>> GetAllTeachers()
        {
            return await _teach.GetAllTeachers();
        }
        [HttpGet]
        public async Task<Teacher> GetTeacherById(int id)
        {
            return await _teach.GetTeacher(id);
        }
        [HttpPost]
        public async Task<string> CreateTeacher([FromForm] TeacherDTO td)
        {
            return await _teach.CreateTeacher(td);
        }
        [HttpPut]
        public async Task<string> UpdateTeacher(int id, [FromForm] TeacherDTO td)
        {
            return await _teach.UpdateTeacher(id, td);
        }
        [HttpDelete]
        public async Task<string> DeleteTeacher(int id)
        {
            return await _teach.DeleteTeacher(id);
        }
    }
}
