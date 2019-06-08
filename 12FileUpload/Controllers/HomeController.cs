using _12FileUpload.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace _12FileUpload.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        FileUploadDbContext db = new FileUploadDbContext();
        public ActionResult Index()
        {
            return View(db.Fileinformations.ToList()); 
        }
        [HttpPost]
        public ActionResult Create(FileInformation model,HttpPostedFileBase someFile)
        {
            FileInformation fi = new FileInformation();
            fi.FileName = Path.GetFileName(someFile.FileName);
            fi.ContentType = someFile.ContentType;

            using (var reader = new BinaryReader(someFile.InputStream))
            {
                fi.Content = reader.ReadBytes(someFile.ContentLength);
            }
            db.Fileinformations.Add(fi);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult DownloadFile(int id)
        {
            FileInformation fi = db.Fileinformations.Find(id);
            return File(fi.Content, fi.ContentType, fi.FileName);
        }

        public ActionResult DeleteFile(int id)
        {
            FileInformation fi = db.Fileinformations.Find(id);
            db.Entry(fi).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}