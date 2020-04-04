using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppForViews.Models;

namespace AppForViews.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            var books = db.Books;

           // ViewBag.Books = books;
           // вапиант строго типизированого представления

            return View(books);
        }

        public ActionResult BookIndex()
        {
            var books = db.Books;

            // ViewBag.Books = books;
            // вапиант строго типизированого представления
            ViewBag.Message = "Это вызов частичного представления из обычного";
            return View(books);
        }


        [HttpGet]
        public ActionResult Buy(int id)
        {

            ViewBag.BookId = id;
            return View();
        }
    
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Спасибо " + purchase.Person + ", за покупку";
        }

        // Partial View Controller

        public ActionResult Partial()
        {
            ViewBag.Message = "Это частичное представление";
            return PartialView();
        }

    }
}