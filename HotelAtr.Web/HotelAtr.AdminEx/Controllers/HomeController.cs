using HotelAtr.AdminEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace HotelAtr.AdminEx.Controllers
{
    public class HomeController : Controller
    {
        private static List<string> _comments = new List<string>();

        [ProfileResultFilter]
        [MyActionFilter]
        public ActionResult Index()
        {//OnActionExecuting

            return View(_comments);
            //Thread.Sleep(3000);
            //return
            //    //OnResultExecuting
            //    View();
            //    //OnResultExecuted
        }//OnActionExecuted

        public ActionResult Index(string id)
        {
            var test = RouteData.Values["id"];
            return View(_comments);
        }

        [HttpPost]
        public ActionResult AddComment(string Comment)
        {
            _comments.Add(Comment);

            var name555 = Request.Form["555"];
            //Thread.Sleep(3000);
            return PartialView("AddComment", Comment);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            if (Request.IsAjaxRequest())
            {
                return PartialView("Contact");
            }

            return View();
        }

        
    }
}