using MVCExamShop.BLL;
using MVCExamShop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExamShop.AdminEx.Controllers
{
    public class InformationController : BaseController
    {
        // GET: Information
        public ActionResult Index()
        {
            return View();
        }

        #region Blogs
        // GET: Blogs
        public ActionResult BlogsList()
        {
            List<Blog> blogs = db.Blogs.ToList();

            return View(blogs);
        }

        public ActionResult CreateBlog(Blog blog, string message)
        {
            ViewBag.Message = message;
            return View(blog);
        }

        [HttpPost]
        public ActionResult CreateBlog(Blog blog)
        {
            string message = "";

            if (InformationService.AddBlog(blog, out message))
                return RedirectToAction("BlogsList");
            else
                return RedirectToAction("CreateBlog", new { blog = blog, message = message });
        }

        public ActionResult EditBlog(int BlogId, string message)
        {
            ViewBag.Message = message;
            Blog blog = db.Blogs.Find(BlogId);
            return View(blog);
        }

        [HttpPost]
        public ActionResult EditBlog(Blog blog)
        {
            string message = "";

            if (InformationService.EditBlog(blog, out message))
                return RedirectToAction("BlogsList");
            else
                return RedirectToAction("EditBlog", new { blog = blog, message = message });
        }

        public ActionResult DeleteBlog(int BlogId, string message)
        {
            ViewBag.Message = message;
            Blog blog = db.Blogs.Find(BlogId);
            return View(blog);
        }

        [HttpPost]
        public ActionResult DeleteBlog(int BlogId)
        {
            string message = "";

            if (InformationService.DeleteBlog(BlogId, out message))
                return RedirectToAction("BlogsList");
            else
                return RedirectToAction("DeleteBlog", new { BlogId = BlogId, message = message });
        }

        public ActionResult DetailsBlog(int BlogId, string message)
        {
            ViewBag.Message = message;
            Blog blog = db.Blogs.Find(BlogId);
            return View(blog);
        }
        #endregion

        #region Comments
        // GET: Comments
        public ActionResult CommentsList()
        {
            List<Comment> comments = db.Comments.ToList();

            return View(comments);
        }

        public ActionResult EditComment(int CommentId, string message)
        {
            ViewBag.Message = message;
            Comment comment = db.Comments.Find(CommentId);
            return View(comment);
        }

        [HttpPost]
        public ActionResult EditComment(Comment comment)
        {
            string message = "";

            if (InformationService.EditComment(comment, out message))
                return RedirectToAction("CommentsList");
            else
                return RedirectToAction("EditComment", new { comment = comment, message = message });
        }

        public ActionResult DeleteComment(int CommentId, string message)
        {
            ViewBag.Message = message;
            Comment comment = db.Comments.Find(CommentId);
            return View(comment);
        }

        [HttpPost]
        public ActionResult DeleteComment(int CommentId)
        {
            string message = "";

            if (InformationService.DeleteComment(CommentId, out message))
                return RedirectToAction("CommentsList");
            else
                return RedirectToAction("DeleteComment", new { CommentId = CommentId, message = message });
        }

        public ActionResult DetailsComment(int CommentId, string message)
        {
            ViewBag.Message = message;
            Comment comment = db.Comments.Find(CommentId);
            return View(comment);
        }
        #endregion
    }
}