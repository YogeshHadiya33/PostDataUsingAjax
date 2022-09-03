using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PostDataUsingAjax.Models
{
    public class Student1
    {
        [Required(ErrorMessage = "Please enter student id")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid id greater than 0")]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Please enter student name")]
        public string StudentName { get; set; }
        [Required(ErrorMessage = "Please select student gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please select student standard")]
        public int Standard { get; set; }
        [Required(ErrorMessage = "Please enter student city")]
        public string City { get; set; }
        public bool IsRegular { get; set; }
    }
}
