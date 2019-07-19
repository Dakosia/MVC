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

        // GET: Menu
        public ActionResult Menu()
        {
            return View();
        }

        // GET: HookahBarDrinks
        public ActionResult HookahBarDrinks()
        {
            List<MenuPoints> menuPoints = db.MenuPoints.ToList();
            List<MenuSections> menuSections = db.MenuSections.ToList();
            ViewData["menuSections"] = menuSections;

            return View(menuPoints);
        }

        // GET: Events
        public ActionResult Events()
        {
            return View();
        }

        // GET: Blog
        public ActionResult Blog()
        {
            List<BlogArticles> blogArticles = db.BlogArticles.ToList();

            return View(blogArticles);
        }

        // GET: ContactUs
        public ActionResult ContactUs()
        {
            List<Branches> branches = db.Branches.ToList();

            return View(branches);
        }
    }
}