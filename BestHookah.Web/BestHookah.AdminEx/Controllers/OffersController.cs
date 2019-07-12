using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestHookah.DAL;
using BestHookah.BLL;

namespace BestHookah.AdminEx.Controllers
{
    public class OffersController : Controller
    {
        BestHookahEntities db = new BestHookahEntities();

        // GET: Offers
        public ActionResult Index()
        {
            List<Offers> offers = db.Offers.ToList();

            return View(offers);
        }

        public ActionResult CreateOffer(Offers offer, string message)
        {
            ViewBag.Message = message;
            return View(offer);
        }

        [HttpPost]
        public ActionResult CreateOffer(Offers offer)
        {
            string message = "";

            if (OffersService.AddOffer(offer, out message))
                return RedirectToAction("Index");
            else
                return RedirectToAction("CreateOffer", new { offer = offer, message = message });
        }
    }
}