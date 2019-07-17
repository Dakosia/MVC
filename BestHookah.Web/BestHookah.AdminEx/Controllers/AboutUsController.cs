using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestHookah.BLL;
using BestHookah.DAL;


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
    }
}