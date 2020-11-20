using CourseManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseManagement.Repository
{
    public interface ICourseRepo
    {
        IEnumerable<Course> GetAllCourses();
        void CreateCourse(Course course);

        void UpdateCourse(Course course);
        void DeleteCourse(int id);
        Course GetCourseById(int id);
    }
}
