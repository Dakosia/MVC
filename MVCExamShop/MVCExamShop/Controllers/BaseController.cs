using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExamShop.DAL;

namespace MVCExamShop.Controllers
{
    public class BaseController : Controller
    {
        public MVCExamOnlineShopEntities db = new MVCExamOnlineShopEntities();
        public string message = "";

        [ChildActionOnly]
        public PartialViewResult Header()
        {
            List<Category> categories = db.Categories.ToList();

            return PartialView("_Header", categories);
        }

        [ChildActionOnly]
        public PartialViewResult Footer()
        {
            List<Blog> blogs = db.Blogs.ToList();

            return PartialView("_Footer", blogs);
        }
    }
}