using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseManagement.Models
{
    public class CoursesDbContext:DbContext
    {
        public CoursesDbContext(DbContextOptions<CoursesDbContext> options):base(options)
        {

        }
        public DbSet<Course> Courses  { get; set; }
       

    }
}
