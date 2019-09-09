using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelAtr.DAL;

namespace HotelAtr.AdminEx.Controllers
{
    public class BaseController : Controller
    {
        public HotelAtrEntities db = new HotelAtrEntities();
        public string message = "";
    }
}