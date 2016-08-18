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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("process/{userText?}")]
        public string Process(string userText)
        {
            if (userText == null)
                return "";

            return userText.ToUpper();
        }

        public string ConvertLowerToUpper(string input)
        {
            if (!String.IsNullOrEmpty(input))
                return input.ToUpper();

            return "";
        }

        [HttpPost]  ///This function is in my controller class
        public ActionResult Delete(string txtDelete)
        {
            int _id = Convert.ToInt32(txtDelete); // put your code   

            return Content("Yes");
        }

        public string WelcomeMsg(string input)
        {
            if (!String.IsNullOrEmpty(input))
                return "Please welcome " + input + ".";
            else
                return "Please enter your name.";
        }


    }
}