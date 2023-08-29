using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Controllers;
namespace MVCDemo.Controllers
{
    public class EmpController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Emp e)
        {
            return View();
        }
    }
}
