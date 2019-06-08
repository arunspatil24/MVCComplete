using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03PartialViews.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TopArticles()
        {
            List<string> articles = new List<string>() {
                "Top 10 CSS Best Practices",
                "Hello World Program in MVC",
                "MY SQL Program",
                ".Net Classes"
            };
            return PartialView("_articles", articles);
        }

        public ActionResult Books()
        {
            List<string> books = new List<string>() {
                "MVC CookBook",
                "Jquery Recipes",
                "C# Experties",
                "Html 5"
            };
            return PartialView("_Books", books);
        }
    }
}