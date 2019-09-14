using MVCExamShop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExamShop.AdminEx.Controllers
{
    public class BaseController : Controller
    {
        public MVCExamOnlineShopEntities db = new MVCExamOnlineShopEntities();
        public string message = "";
    }
}