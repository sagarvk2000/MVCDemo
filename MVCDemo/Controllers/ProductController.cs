using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1, Name="Pen",Price=22.22},
                new Product{Id=2, Name="Pencil",Price=255.22},
                new Product{Id=3, Name="Monitor",Price=2222.22},
                new Product{Id=4, Name="Mouse",Price=252.22},
                new Product{Id=5, Name="Keyboard",Price=666.22},
            };
            ViewData["list"] = products;
            return View();
        }
    }
}
