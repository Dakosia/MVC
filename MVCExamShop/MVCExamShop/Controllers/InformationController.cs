using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExamShop.DAL;
using MVCExamShop.BLL;
using PagedList;
using PagedList.Mvc;

namespace MVCExamShop.Controllers
{
    public class InformationController : BaseController
    {
        // GET: Information
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult DeliveryInformation()
        {
            return View();
        }

        public ActionResult PrivacyPolicy()
        {
            return View();
        }

        public ActionResult TermsAndConditions()
        {
            return View();
        }

        public ActionResult SiteMap()
        {
            List<Category> categories = db.Categories.ToList();

            return View(categories);
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendContactUsForm(Contact contact)
        {
            string message = "";
            if (InformationService.AddContact(contact, out message))
            {
                TempData["Message"] = message;
                if (TempData.ContainsKey("Message"))
                    ViewBag.Message = TempData["Message"].ToString();
                return PartialView("Information/_SendContactUsFormMessage");
            }
            else
                return PartialView("Error");
        }

        

        public ActionResult Blogs(int? page)
        {
            List<Blog> blogs = db.Blogs.ToList();
            ViewData["Blog"] = blogs.OrderByDescending(x => x.BlogCreationDate).ToList();
            ViewData["Comment"] = db.Comments.ToList();

            return View(blogs.OrderByDescending(x => x.BlogCreationDate).ToList().ToPagedList(page ?? 1, 3));
        }

        public ActionResult BlogReadMore(int BlogId)
        {
            Blog blog = db.Blogs.Find(BlogId);
            ViewData["Blog"] = db.Blogs.ToList().OrderByDescending(x => x.BlogCreationDate).ToList();
            ViewData["Comment"] = db.Comments.ToList();

            if (blog != null)
                return View(blog);
            else
                return View("Error");
        }

        [HttpPost]
        public ActionResult AddComment(Comment comment, int BlogId)
        {
            string message = "";
            if (InformationService.AddComment(comment, BlogId, out message))
            {
                TempData["Message"] = message;
                if (TempData.ContainsKey("Message"))
                    ViewBag.Message = TempData["Message"].ToString();
                return PartialView("Information/_AddCommentMessage", comment);
            }
            else
                return PartialView("Error");
        }

        [ChildActionOnly]
        public PartialViewResult AddComment(int BlogId)
        {
            ViewBag.BlogId = BlogId;
            return PartialView("Information/_AddComment");
        }
    }
}