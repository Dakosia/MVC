using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestHookah.DAL;
using BestHookah.BLL;

namespace BestHookah.AdminEx.Controllers
{
    public class GalleryController : Controller
    {
        BestHookahEntities db = new BestHookahEntities();

        // GET: Gallery
        public ActionResult Index()
        {
            List<Gallery> galleries = db.Gallery.ToList();

            return View(galleries);
        }

        public ActionResult CreateImage(Gallery image, string message)
        {
            ViewBag.Message = message;
            return View(image);
        }

        [HttpPost]
        public ActionResult CreateImage(Gallery image)
        {
            string message = "";

            if (GalleryService.AddImage(image, out message))
                return RedirectToAction("Index");
            else
                return RedirectToAction("CreateImage", new { image = image, message = message });
        }

        public ActionResult EditImage(int Imageid, string message)
        {
            ViewBag.Message = message;
            Gallery image = db.Gallery.Find(Imageid);
            return View(image);
        }

        [HttpPost]
        public ActionResult EditImage(Gallery image)
        {
            string message = "";

            if (GalleryService.EditImage(image, out message))
                return RedirectToAction("Index");
            else
                return RedirectToAction("EditImage", new { image = image, message = message });
        }

        public ActionResult DeleteImage(int Imageid, string message)
        {
            ViewBag.Message = message;
            Gallery image = db.Gallery.Find(Imageid);
            return View(image);
        }

        [HttpPost]
        public ActionResult DeleteImage(int Imageid)
        {
            string message = "";

            if (GalleryService.DeleteImage(Imageid, out message))
                return RedirectToAction("Index");
            else
                return RedirectToAction("DeleteImage", new { Imageid = Imageid, message = message });
        }

        public ActionResult DetailsImage(int Imageid, string message)
        {
            ViewBag.Message = message;
            Gallery image = db.Gallery.Find(Imageid);
            return View(image);
        }
    }
}