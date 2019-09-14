using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExamShop.DAL;
using MVCExamShop.BLL;

namespace MVCExamShop.Controllers
{
    public class ProductController : BaseController
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Brands()
        {
            List<Brand> brands = db.Brands.ToList();

            return View(brands);
        }

        public ActionResult Specials()
        {
            List<Product> products = db.Products.ToList();
            return View(products);
        }

        public ActionResult Returns()
        {
            return View();
        }

        public ActionResult GiftCertificates()
        {
            return View();
        }

        public ActionResult Men()
        {
            List<Product> products = db.Products.ToList();
            return View(products);
        }
    }
}