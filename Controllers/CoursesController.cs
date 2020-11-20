using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CourseManagement.Models;
using CourseManagement.Repository;
using CourseManagement.ViewModels;
using CourseManagement.Serialization;

namespace CourseManagement.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseRepo _repository;

        public CoursesController(ICourseRepo repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {            
            return View(_repository.GetAllCourses());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return PartialView("_CourseCreateModelPartial");
        }

        [HttpPost]
        public IActionResult Create(CourseViewModel model)
        {
            if (ModelState.IsValid)
            {
                var courses = CourseMapper.SerializeCourse(model);    
                _repository.CreateCourse(courses);
                return PartialView("_CourseSuccessPartial");
            }
            return PartialView("_CourseCreateModelPartial", model);
          
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {

            var model = _repository.GetCourseById(id);
            var viewModel = CourseMapper.SerializeCourse(model);
            return PartialView("_CourseEditModelPartial", viewModel);
        }
        [HttpPost]
        public IActionResult Edit(CourseViewModel model)
        {
            if (ModelState.IsValid)
            {
                var course = CourseMapper.SerializeCourse(model);
                _repository.UpdateCourse(course);
                return PartialView("_CourseSuccessPartial");
            }
            return PartialView("_CourseEditModelPartial", model);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _repository.GetCourseById(id);
            return PartialView("_CourseDeleteModelPartial", model);
        }
        [HttpPost]
        public IActionResult Delete(Course model)
        {
             _repository.DeleteCourse(model.Id);
            return PartialView("_CourseSuccessPartial");
        }
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
