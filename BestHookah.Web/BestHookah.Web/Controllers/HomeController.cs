using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestHookah.DAL;
using BestHookah.BLL;

namespace BestHookah.Web.Controllers
{
    public class HomeController : Controller
    {
        BestHookahEntities db = new BestHookahEntities();

        public ActionResult Index()
        {
            ViewData["Reviews"] = HomeService.Review();
            return View();
        }

        public ActionResult CreateReview(Reviews review, string message)
        {
            ViewBag.Message = message;
            return View(review);
        }

        [HttpPost]
        public ActionResult CreateReview(Reviews review)
        {
            string message = "";

            if (HomeService.AddReview(review, out message))
                return RedirectToAction("Index");
            else
                return RedirectToAction("CreateReview", new { review = review, message = message });
        }
    }
}