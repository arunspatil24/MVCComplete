using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02TempDataViewDataViewBagSession.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult Demo()
        {
            string name = "Ram";
            int age = 30;
            ViewData["Name"] = name;
            ViewData["Age"] = age;

            TempData["City"] = "Goa";

            ViewBag.PhoneNumber = "8892922248";

            Session["Country"] = "India";
            return View();
        }


        public ActionResult Demo1()
        {
            return View();
        }
    }
}