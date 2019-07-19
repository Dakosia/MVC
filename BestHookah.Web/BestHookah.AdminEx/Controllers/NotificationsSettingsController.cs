using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestHookah.DAL;
using BestHookah.BLL;

namespace BestHookah.AdminEx.Controllers
{
    public class NotificationsSettingsController : Controller
    {
        BestHookahEntities db = new BestHookahEntities();

        // GET: NotificationsSettings
        public ActionResult Index()
        {
            List<Notifications> notifications = db.Notifications.ToList();

            return View(notifications);
        }

        public ActionResult CreateUser(Notifications user, string message)
        {
            ViewBag.Message = message;
            return View(user);
        }

        [HttpPost]
        public ActionResult CreateUser(Notifications user)
        {
            string message = "";

            if (NotificationsService.AddUser(user, out message))
                return RedirectToAction("Index");
            else
                return RedirectToAction("CreateUser", new { user = user, message = message });
        }

        public ActionResult EditUser(int UserId, string message)
        {
            ViewBag.Message = message;
            Notifications user = db.Notifications.Find(UserId);
            return View(user);
        }

        [HttpPost]
        public ActionResult EditUser(Notifications user)
        {
            string message = "";

            if (NotificationsService.EditUser(user, out message))
                return RedirectToAction("Index");
            else
                return RedirectToAction("EditUser", new { user = user, message = message });
        }

        public ActionResult DeleteUser(int UserId, string message)
        {
            ViewBag.Message = message;
            Notifications user = db.Notifications.Find(UserId);
            return View(user);
        }

        [HttpPost]
        public ActionResult DeleteUser(int UserId)
        {
            string message = "";

            if (NotificationsService.DeleteUser(UserId, out message))
                return RedirectToAction("Index");
            else
                return RedirectToAction("DeleteUser", new { UserId = UserId, message = message });
        }

        public ActionResult DetailsUser(int UserId, string message)
        {
            ViewBag.Message = message;
            Notifications user = db.Notifications.Find(UserId);
            return View(user);
        }
    }
}