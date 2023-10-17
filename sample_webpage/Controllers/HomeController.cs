using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sample_webpage.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult welcome()
        {
            string name = Request.Form["name"];
            int age = int.Parse(Request.Form["age"]);
            if (age > 18)
            {
                ViewBag.msg = "welcome !! " + name + ", You are eligible to visit this page";
            }
            else
            {
                ViewBag.msg = "welcome !! " + name + ", You are not eligible to visit this page";
            }
            Session["name"] = name;
            Session["age"] = age;
            return View();

        }
    }
}
