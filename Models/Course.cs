using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseManagement.Models
{
    public class Course
    {
        public int Id { get; set; }

        [MaxLength(64)]
        [Required(ErrorMessage = "Name is Required")]
        [DisplayName("Course")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Price is Required")]
        public decimal Price { get; set; }
      
        [Required(ErrorMessage = "StartTime is Required")]
        [DisplayName("Start date")]
        public DateTime startDate { get; set; }
        [Required(ErrorMessage = "EndTime is Required")]
        [DisplayName("End date duration")]
        public DateTime endDate { get; set; }

    }
}
