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
            ViewData["fruitlist"] = new List<string>()
            {
                "Apple",
                "Orange",
                "Mango"
            };
            return View();
        }

        public ActionResult BookEntry()
        {
            return View();
        }
    }
}