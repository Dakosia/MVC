using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestHookah.DAL;

namespace BestHookah.Web.Controllers
{
    public class AboutUsController : Controller
    {
        BestHookahEntities db = new BestHookahEntities();

        // GET: AboutUs
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactUs
        public ActionResult ContactUs()
        {
            List<Branches> branches = db.Branches.ToList();

            return View(branches);
        }

        // GET: HookahBarDrinks
        public ActionResult HookahBarDrinks()
        {
            return View();
        }

        // GET: Blog
        public ActionResult Blog()
        {
            return View();
        }
    }
}