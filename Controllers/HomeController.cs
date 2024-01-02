using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["topbooklist"] = new List<string>()
            {
                "Harry Potter and the chamber of the secrets",
                "The Alchemist",
                "The Lord of the rings"
            };
            return View();
        }
        public ActionResult UserRegistration()
        {
            return View();
        }

        public ActionResult BookEntry()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BookDataEntry(string title, string genre, string price)
        {
            
        }
    }
}