using CourseManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseManagement.Repository
{
    public class CourseRepo : ICourseRepo
    {
        private readonly CoursesDbContext _db;
        public CourseRepo(CoursesDbContext db)
        {
            _db = db;
        }
        public void CreateCourse(Course course)
        {
            _db.Courses.Add(course);
            _db.SaveChanges();
        }

        public void DeleteCourse(int id)
        {
            var course = _db.Courses.Find(id);
           
            _db.Courses.Remove(course);
            _db.SaveChanges();
           
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _db.Courses                
                .ToList();
        }

        public void UpdateCourse(Course course)
        {
            _db.Courses.Update(course);
            _db.SaveChanges();
        }
        public Course GetCourseById(int id)
        {
            return _db.Courses.Find(id);
        }
    }
}
