﻿using System.Web.Mvc;
using System.Web.Routing;

namespace MvcCabBooking
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)  
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Default",
                url: "{Controller}/{action}/{id}",
                defaults: new { controller = "Cab", action = "SignUp", id = UrlParameter.Optional }
            );
        }
    }
}
