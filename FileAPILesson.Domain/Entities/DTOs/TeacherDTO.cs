using FileAPILesson.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAPILesson.Domain.Entities.DTOs
{
    public class TeacherDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Salary { get; set; }
        public List<Group> Groups { get; set; }
    }
}
