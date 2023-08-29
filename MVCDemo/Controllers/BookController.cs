using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
namespace MVCDemo.Controllers
{
    public class BookController : Controller
    {
        public IActionResult BookList()
        {
            List<Book> book = new List<Book>()
            {
                new Book{Id=1,Name="Wings Of Fire",Price=499},
                new Book{Id=2,Name="Lord of the Rings",Price=599},
                new Book{Id=3,Name="Harry Potter",Price=899},
                new Book{Id=4,Name="Rich Dad Poor Dad",Price=399},
            };
            ViewData["list"]= book;

            ViewBag.BookList = book;
            return View();
        }
    }
}
