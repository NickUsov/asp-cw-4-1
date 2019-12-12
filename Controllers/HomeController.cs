using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Book book)
        {
            if (ModelState.IsValid)
            {
                repository.Add(book);
                return View("Thanks", repository.Count);
            }
            else
                return RedirectToAction("Index");
        }

        IRepository repository;
        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }
    }
}