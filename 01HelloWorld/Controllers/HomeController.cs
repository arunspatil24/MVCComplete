using System.Web.Mvc;

namespace _01HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Hello This is World";
        }

        public string Name(string name)
        {
            return "Hello " + name;
        }

        public string Add(int n1, int n2)
        {
            return "<h1> The addition of two numbers " + n1 + " and " + n2 + " is " + (n1 + n2) + "</h1>";
        }

        public ActionResult Hello()
        {
            return View();
        }

        public ActionResult ShowTime()
        {
            return View();
        }

        public ActionResult Addition()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Addition(int n1, int n2)
        {
            int result = n1 + n2;
            return View(result);
        }

        public ActionResult CalculateInterest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalculateInterest(int pm,int roi,int tp)
        {
            float result = (pm * tp * roi) / 100;
            return View(result);
        }
    }
}