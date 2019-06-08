using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _1234File.Models;
using System.IO;
using System.Data.Entity;

namespace _1234File.Controllers
{
    public class HomeController : Controller
    {
        FileDbContext db = new FileDbContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Fileinfos.ToList());
        }

        [HttpPost]
        public ActionResult Create(Fileinfo model, HttpPostedFileBase someFile)
        {
            Fileinfo fi = new Fileinfo();
            fi.FileName = Path.GetFileName(someFile.FileName);
            fi.ContentType = someFile.ContentType;

            using (var reader = new BinaryReader(someFile.InputStream))
            {
                fi.Content = reader.ReadBytes(someFile.ContentLength);
            }

            db.Fileinfos.Add(fi);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }


        public ActionResult DownloadFile(int id)
        {
            Fileinfo fi = db.Fileinfos.Find(id);
            return File(fi.Content, fi.ContentType, fi.FileName);
        }

        public ActionResult DeleteFile(int id)
        {
            Fileinfo fi = db.Fileinfos.Find(id);
            db.Entry(fi).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}