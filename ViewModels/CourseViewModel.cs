using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseManagement.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        [MaxLength(64)]
        [Required(ErrorMessage = "Name is Required")]
        [DisplayName("Course Name")]
        public string Name { get; set; }
      
        [Required(ErrorMessage = "Price is Required")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Start Date is Required")]
        public DateTime startDate { get; set; }

        [Required(ErrorMessage = "Duration is Required")]
        public int Duration { get; set; }

    }
}
