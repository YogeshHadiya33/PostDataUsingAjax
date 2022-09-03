using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostDataUsingAjax.Models
{

    public class Student
    {       
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public int Standard { get; set; }
        public string City { get; set; }
        public bool IsRegular { get; set; }
    }
}
