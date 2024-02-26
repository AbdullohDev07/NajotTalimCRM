using FileAPILesson.Domain.Entities.DTOs;
using FileAPILesson.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAPILesson.Application.Services.TeacherServices
{
    public interface ITeacherService
    {
        public Task<string> CreateTeacher(TeacherDTO tr);
        public Task<string> UpdateTeacher(int id, TeacherDTO tr);
        public Task<string> DeleteTeacher(int id);
        public Task<Teacher> GetTeacher(int id);
        public Task<IEnumerable<Teacher>> GetAllTeachers();
    }
}
