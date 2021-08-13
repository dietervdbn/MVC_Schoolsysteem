using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Schoolsysteem.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Voornaam is verplicht!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Naam is verplicht!")]
        public string Lastname { get; set; }
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments{ get; set; }
    }
}
