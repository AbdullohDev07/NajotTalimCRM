using FileAPILesson.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAPILesson.Domain.Entities.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Route { get; set; }
        public GroupType GrType { get; set; }
        public string Duration { get; set; }
    }
}
