using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestHookah.DAL;
using BestHookah.BLL;
using PagedList;
using PagedList.Mvc;

namespace BestHookah.AdminEx.Controllers
{
    public class ReservationController : Controller
    {
        BestHookahEntities db = new BestHookahEntities();

        // GET: Reservation
        public ActionResult ReservesList(int? page)
        {
            List<Reserves> reserves = db.Reserves.ToList();
            return View(reserves.ToPagedList(page ?? 1, 20));
        }

        public ActionResult Filter(DateTime? from, DateTime? to)
        {
            if (from == null || to == null)
            {
                return RedirectToAction("ReservesList");
            }
            else
            {
                return View("ReservesList", ReservationService.FilterByDate(from, to));
            }
        }

        public ActionResult GetTodayReservesExcel()
        {
            string fileUrl = Server.MapPath(@"\Uploads\Reservations.xlsx");
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            return File(ReservationService.GetTodayReservesExcel(fileUrl), contentType);
        }
    }
}