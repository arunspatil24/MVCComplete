using _07ModelValidations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace _07ModelValidations.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDbContext db = new EmployeeDbContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
            
        }
    }
}