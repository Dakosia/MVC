using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelAtr.DAL;
using HotelAtr.BLL;

namespace HotelAtr.Web.Controllers
{
    public class RoomController : Controller
    {
        HotelAtrEntities db = new HotelAtrEntities();

        // GET: Room
        public ActionResult Index()
        {
            List<Rooms> rooms = db.Rooms.ToList();

            //наша пр-ие я-ся строго типизированным
            return View(rooms);
        }

        public ActionResult RoomDetails(int RoomId)
        {
            var room = db.Rooms.Find(RoomId);

            if (room != null)
            {
                ViewBag.AdultsList = new List<string>() { "1", "2", "3", "4", "5" };
                ViewBag.ChildrenList = new List<string>() { "1", "2", "3", "4", "5" };

                if (TempData.ContainsKey("Message"))
                    ViewBag.Message = TempData["Message"].ToString();

                return View(room);
            }
            else
                return View("Error");
        }

        [HttpPost]
        public ActionResult RoomReserve(RoomReserve roomReserve)
        {
            string message = "";

            ServiceRoom.RoomReserve(roomReserve, out message);
            TempData["Message"] = message;

            return RedirectToAction("RoomDetails", new { RoomId = roomReserve.RoomId });


            //if (ServiceRoom.RoomReserve(roomReserve, out message))
            //{
            //    return RedirectToAction("RoomDetails", new { RoomId = 0 });
            //}
            //else
            //{
            //    return RedirectToAction("RoomDetails", new { RoomId = 0 });
            //}
        }
        public JsonResult GetRoomReserveDates()
        {
           var roomReserves = db.RoomReserve.ToList();
            return Json(new
            {
                roomReservesA = roomReserves.Select(s => s.Arrive),
                roomReservesD = roomReserves.Select(s => s.Departure)
            },
            JsonRequestBehavior.AllowGet);
        }
    }
}