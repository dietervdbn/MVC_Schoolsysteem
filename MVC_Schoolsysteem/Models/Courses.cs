using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Schoolsysteem.Models
{
    public class Courses
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Titel is verplicht!")]
        public string Title { get; set; }
        public string Credits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
