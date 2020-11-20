using CourseManagement.Models;
using CourseManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseManagement.Serialization
{
    public class CourseMapper
    {
        public static CourseViewModel SerializeCourse(Course course)
        {
            return new CourseViewModel
            {
                Id = course.Id,
                Name = course.Name,
                Price = course.Price,
                startDate = course.startDate,
                Duration =(int)(course.endDate-course.startDate).TotalMinutes,
                
            };

        }
        public static Course SerializeCourse(CourseViewModel course)
        {
            return new Course
            {
                Id = course.Id,
                Name = course.Name,
                Price = course.Price,
                startDate=course.startDate,
                endDate=course.startDate.AddMinutes(course.Duration)
                
            };
        }
    }
}
