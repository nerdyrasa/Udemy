using Ajax.Models;
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

        // This works for both Get and Post.
        // [HttpGet] is the default even if one isn't specified, but why does Post work?

        public string ConvertLowerToUpper(string input)
        {
            if (!String.IsNullOrEmpty(input))
                return input.ToUpper();

            return "";
        }


        // Attribute routing
        // http://www.asp.net/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2


        [Route("PutBook/{id}")]
        public string PutBook(int id, Book book)
        {
            // do update here

            return "Success";
        }

        // This put request works even without [HttpPut].
        [Route("UpdateBook/{id}")]
        public string UpdateBook(int id, Book book)
        {
            // do update here

            return "204";
        }

    }
}