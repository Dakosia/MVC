using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestHookah.DAL;
using PagedList;
using PagedList.Mvc;

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
        public ActionResult Blog(int? page)
        {
            List<BlogArticles> blogArticles = db.BlogArticles.ToList();
            ViewData["BlogArticles"] = blogArticles.OrderByDescending(x => x.BlogArticleCreationDate).ToList();
            
            return View(blogArticles.OrderByDescending(x => x.BlogArticleCreationDate).ToList().ToPagedList(page ?? 1, 3));
        }

        public ActionResult BlogReadMore(int BlogArticleId)
        {
            BlogArticles blogArticle = db.BlogArticles.Find(BlogArticleId);
            ViewData["BlogArticles"] = db.BlogArticles.ToList().OrderByDescending(x => x.BlogArticleCreationDate).ToList();

            if (blogArticle != null)
                return View(blogArticle);
            else
                return View("Error");
        }

        // GET: ContactUs
        public ActionResult ContactUs()
        {
            List<Branches> branches = db.Branches.ToList();

            return View(branches);
        }
    }
}