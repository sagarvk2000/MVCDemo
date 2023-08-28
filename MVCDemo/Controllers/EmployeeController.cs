using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmpList()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee{Id=1,Name="Sagar",Salary=40000},
                new Employee{Id=2,Name="Pankaj",Salary=45000},
                new Employee{Id=3,Name="Nilesh",Salary=50000},
                new Employee{Id=4,Name="Girish",Salary=55000}
            };
            ViewData["list"] = emp;
            return View();
        }
    }
}
