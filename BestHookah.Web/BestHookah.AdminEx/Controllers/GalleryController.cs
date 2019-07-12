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

        public ActionResult EditImage(int id, string message)
        {
            ViewBag.Message = message;
            Gallery image = db.Gallery.Find(id);
            return View(image);
        }

        [HttpPost]
        public ActionResult EditImage(Gallery image)
        {
            string message = "";

            if (GalleryService.EditImage(image, out message))
                return RedirectToAction("Index");
            else
                return RedirectToAction("EditImage", new { id = image.ImageId, message = message });
        }

        public ActionResult DeleteImage(int id, string message)
        {
            ViewBag.Message = message;
            Gallery image = db.Gallery.Find(id);
            return View(image);
        }

        [HttpPost]
        public ActionResult DeleteImage(int id)
        {
            string message = "";

            if (GalleryService.DeleteImage(id, out message))
                return RedirectToAction("Index");
            else
                return RedirectToAction("DeleteImage", new { id = id, message = message });
        }

        public ActionResult DetailsImage(int id, string message)
        {
            ViewBag.Message = message;
            Gallery image = db.Gallery.Find(id);
            return View(image);
        }
    }
}