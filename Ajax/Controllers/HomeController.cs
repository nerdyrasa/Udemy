using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ajax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Explore. Discover. Understand.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My contact info will go here eventually.";

            return View();
        }

        public string ConvertLowerToUpper(string input)
        {
            if (!String.IsNullOrEmpty(input))
                return input.ToUpper();

            return "";
        }

    }
}