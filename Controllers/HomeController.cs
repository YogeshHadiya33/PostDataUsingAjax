using Microsoft.AspNetCore.Mvc;
using PostDataUsingAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostDataUsingAjax.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SaveStudentWithoutSerialize(Student student)
        {
            return Json("student saved successfully");
        }

        public  IActionResult WithValidation()
        {
            return View();
        }


        [HttpPost]
        public JsonResult SaveStudentWithSerialize(Student1 student1)
        {
            return Json("student saved successfully");
        }
    }
}
