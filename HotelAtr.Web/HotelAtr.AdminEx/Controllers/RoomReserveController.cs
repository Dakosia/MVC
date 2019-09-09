using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelAtr.DAL;
using HotelAtr.BLL;

namespace HotelAtr.AdminEx.Controllers
{
    public class RoomReserveController : BaseController
    {
        // GET: RoomReserve
        public ActionResult Index()
        {
            List<RoomReserve> roomReserves = db.RoomReserve.ToList();
            return View(roomReserves);
        }

        public ActionResult EditRoomReserve(int RoomReserveId)
        {
            RoomReserve roomReserve = db.RoomReserve.Find(RoomReserveId);
            return View(roomReserve);
        }

        [HttpPost]
        public ActionResult EditRoomReserve(RoomReserve roomReserve)
        {
            ServiceRoom.EditRoomReserve(roomReserve, out message);
            return RedirectToAction("Index");
        }

        public ActionResult ApproveRoomReserve(int RoomReserveId)
        {
            ServiceRoom.ApproveRoomReserve(RoomReserveId, out message);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteRoomReserve(int RoomReserveId)
        {
            ServiceRoom.DeleteRoomReserve(RoomReserveId, out message);
            return RedirectToAction("Index");
        }

        public ActionResult DeclineRoomReserve(int RoomReserveId)
        {
            ServiceRoom.DeclineRoomReserve(RoomReserveId, out message);
            return RedirectToAction("Index");
        }
    }
}