using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelAtr.AdminEx.Models
{
    public class ExceptionExAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {

            if(!filterContext.ExceptionHandled)
            {
                filterContext.Result = new RedirectResult("/SomeErrorPage.html");
                filterContext.ExceptionHandled = true;
            }
        }
    }
}