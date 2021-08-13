using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Schoolsysteem.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public char Grade { get; set; }
        public int? StudentId { get; set; }
        public Student Student{ get; set; }
        public int? CourseId { get; set; }
        public Courses Course { get; set; }
    }
}
