using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelAtr.AdminEx.Models
{
    public class CustomAuthAttribute : AuthorizeAttribute
    {
        private string[] allowedUsers;

        public CustomAuthAttribute(params string[] users)
        {
            allowedUsers = users;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {

            if (httpContext.Request.IsLocal)
                return true;
            else
                return
                    httpContext.Request.IsAuthenticated &&
                    allowedUsers.Contains(httpContext.User.Identity.Name, StringComparer.CurrentCultureIgnoreCase);
        }

    }

    public class AjaxAuthorizeAuthAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if(!filterContext.HttpContext.Request.IsAjaxRequest()

                /*  && !filterContext.HttpContext.Request.IsAuthenticated*/)
            {
                UrlHelper urlHelper = new UrlHelper(filterContext.RequestContext);

                filterContext.Result = new JsonResult
                {
                    Data = new
                    {
                        Error = "NotAuthorized",
                        LogOnUrl = urlHelper.Action("LogOn", "Account")
                    },
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
           
        }
    }
}