using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HotelAtr.AdminEx
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //6
            routes.MapRoute("111",
                "phpMyAdmin/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = "default" });

            ////5
            //routes.MapRoute("111",
            //    "{phpMyAdmin}/{action}",
            //    defaults: new { controller = "Home", action = "Index" });

            ////4
            //routes.MapRoute("111",
            //    "ws{contoller}/{action}",
            //    defaults: new { controller = "Home", action = "Index" });

            ////3
            //routes.MapRoute("111", 
            //    "egov/{contoller}/{action}", 
            //    defaults: new { controller = "Home", action = "Index" });

            ////2
            //routes.MapRoute("111", "{contoller}/{action}");

            ////1
            //Route myRoute = new Route("{contoller}/{action}", new MvcRouteHandler());

            //routes.Add(myRoute);



            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
