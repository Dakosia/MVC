using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestHookah.BLL;
using BestHookah.DAL;
using PagedList;
using PagedList.Mvc;


namespace BestHookah.AdminEx.Controllers
{
    public class AboutUsController : Controller
    {
        BestHookahEntities db = new BestHookahEntities();

        //// GET: AboutUs
        //public ActionResult Index()
        //{
        //    return View();
        //}
        

        #region Hookah Bar & Drinks

        #region Menu Sections
        // GET: MenuSections
        public ActionResult MenuSectionsList(int? page)
        {
            List<MenuSections> menuSections = db.MenuSections.ToList();

            return View(menuSections.ToPagedList(page ?? 1, 5));
        }

        public ActionResult CreateMenuSection(MenuSections menuSection, string message)
        {
            ViewBag.Message = message;
            return View(menuSection);
        }

        [HttpPost]
        public ActionResult CreateMenuSection(MenuSections menuSection)
        {
            string message = "";

            if (AboutUsService.AddMenuSection(menuSection, out message))
                return RedirectToAction("MenuSectionsList");
            else
                return RedirectToAction("CreateMenuSection", new { menuSection = menuSection, message = message });
        }

        public ActionResult EditMenuSection(int MenuSectionId, string message)
        {
            ViewBag.Message = message;
            MenuSections menuSection = db.MenuSections.Find(MenuSectionId);
            return View(menuSection);
        }

        [HttpPost]
        public ActionResult EditMenuSection(MenuSections menuSection)
        {
            string message = "";

            if (AboutUsService.EditMenuSection(menuSection, out message))
                return RedirectToAction("MenuSectionsList");
            else
                return RedirectToAction("EditMenuSection", new { menuSection = menuSection, message = message });
        }

        public ActionResult DeleteMenuSection(int MenuSectionId, string message)
        {
            ViewBag.Message = message;
            MenuSections menuSection = db.MenuSections.Find(MenuSectionId);
            return View(menuSection);
        }

        [HttpPost]
        public ActionResult DeleteMenuSection(int MenuSectionId)
        {
            string message = "";

            if (AboutUsService.DeleteMenuSection(MenuSectionId, out message))
                return RedirectToAction("MenuSectionsList");
            else
                return RedirectToAction("DeleteMenuSection", new { MenuSectionId = MenuSectionId, message = message });
        }

        public ActionResult DetailsMenuSection(int MenuSectionId, string message)
        {
            ViewBag.Message = message;
            MenuSections menuSection = db.MenuSections.Find(MenuSectionId);
            return View(menuSection);
        }
        #endregion


        #region Menu Points
        // GET: MenuPoints
        public ActionResult MenuPointsList(int? page)
        {
            List<MenuPoints> menuPoints = db.MenuPoints.ToList();

            return View(menuPoints.ToPagedList(page ?? 1, 5));
        }

        public ActionResult CreateMenuPoint(MenuPoints menuPoint, string message)
        {
            ViewBag.Message = message;
            return View(menuPoint);
        }

        [HttpPost]
        public ActionResult CreateMenuPoint(MenuPoints menuPoint)
        {
            string message = "";

            if (AboutUsService.AddMenuPoint(menuPoint, out message))
                return RedirectToAction("MenuPointsList");
            else
                return RedirectToAction("CreateMenuPoint", new { menuPoint = menuPoint, message = message });
        }

        public ActionResult EditMenuPoint(int MenuPointId, string message)
        {
            ViewBag.Message = message;
            MenuPoints menuPoint = db.MenuPoints.Find(MenuPointId);
            return View(menuPoint);
        }

        [HttpPost]
        public ActionResult EditMenuPoint(MenuPoints menuPoint)
        {
            string message = "";

            if (AboutUsService.EditMenuPoint(menuPoint, out message))
                return RedirectToAction("MenuPointsList");
            else
                return RedirectToAction("EditMenuPoint", new { menuPoint = menuPoint, message = message });
        }

        public ActionResult DeleteMenuPoint(int MenuPointId, string message)
        {
            ViewBag.Message = message;
            MenuPoints menuPoint = db.MenuPoints.Find(MenuPointId);
            return View(menuPoint);
        }

        [HttpPost]
        public ActionResult DeleteMenuPoint(int MenuPointId)
        {
            string message = "";

            if (AboutUsService.DeleteMenuPoint(MenuPointId, out message))
                return RedirectToAction("MenuPointsList");
            else
                return RedirectToAction("DeleteMenuPoint", new { MenuPointId = MenuPointId, message = message });
        }

        public ActionResult DetailsMenuPoint(int MenuPointId, string message)
        {
            ViewBag.Message = message;
            MenuPoints menuPoint = db.MenuPoints.Find(MenuPointId);
            return View(menuPoint);
        }
        #endregion

        #endregion

        #region Blog
        // GET: Blog
        public ActionResult BlogArticlesList()
        {
            List<BlogArticles> blogArticles = db.BlogArticles.ToList();

            return View(blogArticles);
        }

        public ActionResult CreateBlogArticle(BlogArticles blogArticle, string message)
        {
            ViewBag.Message = message;
            return View(blogArticle);
        }

        [HttpPost]
        public ActionResult CreateBlogArticle(BlogArticles blogArticle)
        {
            string message = "";

            if (AboutUsService.AddBlogArticle(blogArticle, out message))
                return RedirectToAction("BlogArticlesList");
            else
                return RedirectToAction("CreateBlogArticle", new { blogArticle = blogArticle, message = message });
        }
        #endregion

        #region Contact Us
        // GET: ContactUs
        public ActionResult BranchesList()
        {
            List<Branches> branches = db.Branches.ToList();

            return View(branches);
        }

        public ActionResult CreateBranch(Branches branch, string message)
        {
            ViewBag.Message = message;
            return View(branch);
        }

        [HttpPost]
        public ActionResult CreateBranch(Branches branch)
        {
            string message = "";

            if (AboutUsService.AddBranch(branch, out message))
                return RedirectToAction("BranchesList");
            else
                return RedirectToAction("CreateBranch", new { branch = branch, message = message });
        }

        public ActionResult EditBranch(int BranchId, string message)
        {
            ViewBag.Message = message;
            Branches branch = db.Branches.Find(BranchId);
            return View(branch);
        }

        [HttpPost]
        public ActionResult EditBranch(Branches branch)
        {
            string message = "";

            if (AboutUsService.EditBranch(branch, out message))
                return RedirectToAction("BranchesList");
            else
                return RedirectToAction("EditBranch", new { branch = branch, message = message });
        }

        public ActionResult DeleteBranch(int BranchId, string message)
        {
            ViewBag.Message = message;
            Branches branch = db.Branches.Find(BranchId);
            return View(branch);
        }

        [HttpPost]
        public ActionResult DeleteBranch(int BranchId)
        {
            string message = "";

            if (AboutUsService.DeleteBranch(BranchId, out message))
                return RedirectToAction("BranchesList");
            else
                return RedirectToAction("DeleteBranch", new { BranchId = BranchId, message = message });
        }

        public ActionResult DetailsBranch(int BranchId, string message)
        {
            ViewBag.Message = message;
            Branches branch = db.Branches.Find(BranchId);
            return View(branch);
        }
        #endregion
    }
}