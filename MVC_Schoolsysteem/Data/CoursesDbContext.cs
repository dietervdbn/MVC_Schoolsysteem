using Microsoft.EntityFrameworkCore;
using MVC_Schoolsysteem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Schoolsysteem.Data
{
    public class CoursesDbContext : DbContext
    {
        public CoursesDbContext(DbContextOptions<CoursesDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Studenten { get; set; }
        public DbSet<Courses> Courses{ get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
