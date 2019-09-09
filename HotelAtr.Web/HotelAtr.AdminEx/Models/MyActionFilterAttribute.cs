using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelAtr.AdminEx.Models
{
    public class MyActionFilterAttribute : FilterAttribute, IActionFilter
    {
        public Stopwatch sw;

        //После
        public void OnActionExecuted(ActionExecutedContext filter)
        {
            sw.Stop();
            var result = sw.Elapsed.Milliseconds;

            //if (!filter.HttpContext.Request.IsSecureConnection)
            //{
            //    filter.Result = new HttpNotFoundResult();
            //}
        }

        //Перед вызовом метода действия
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            sw = Stopwatch.StartNew();
            int x = 0;
        }
    }

    public class ProfileResultFilterAttribute : FilterAttribute, IResultFilter
    {
        public Stopwatch sw;

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            sw.Stop();
            var result = sw.Elapsed.Milliseconds;
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            sw = Stopwatch.StartNew();
        }
    }
}