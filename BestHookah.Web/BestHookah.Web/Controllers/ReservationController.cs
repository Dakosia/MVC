using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestHookah.DAL;
using BestHookah.BLL;

namespace BestHookah.Web.Controllers
{
    public class ReservationController : Controller
    {
        BestHookahEntities db = new BestHookahEntities();

        // GET: Reservation
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateReserve(Reserves reserve)
        {
            string message = "";
            ReservationService.AddReserve(reserve, out message);
            ReservationService.Notify();
            return RedirectToAction("Index", new { message = message });
        }

    }
}