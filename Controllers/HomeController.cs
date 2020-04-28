using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        BookContext db;

        public HomeController(BookContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Books.ToList());
        }

        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("index");
            }
            
            ViewBag.BookId = id;

            return View();
        }

        [HttpPost]
        public string Buy(Order order)
        {
            if(order.Name == null || order.Adress == null || order.PhoneNumber == null)
            {
                return "Ошибка! Введите корректно данные";
            }

            db.Orders.Add(order);
            db.SaveChanges();

            order.Book = db.Books.Where(it => order.BookId == it.Id).Single();

            return "Спасибо, " + order.Name + ", за покупку книги " + order.Book.Author + " " + order.Book.Name;
        }

    }
}
