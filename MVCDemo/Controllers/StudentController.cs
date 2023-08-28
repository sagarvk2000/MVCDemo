using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentList()
        {
            List<Student> students = new List<Student>()
            {
                new Student{Id=1,Name="sagar",Percentage=87.47},
                new Student{Id=2,Name="pankaj",Percentage=55},
                new Student{Id=3,Name="pratik",Percentage=67.47},
                new Student{Id=4,Name="nilesh",Percentage=72},
                new Student{Id=5,Name="girish",Percentage=75}
            };
            ViewData["list"] = students;
            return View();
        }
    }
}
