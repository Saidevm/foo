using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCWebApplicationFoo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Example to map non default route
            routes.MapRoute(
                name: "Serial Number",
                url: "serial/{lcase}",
                defaults: new
                {
                    controller = "Home",
                    action = "Serial",
                    lcase = "upper"
                }
            );

            // Default route
            routes.MapRoute(
                name: "Default", 
                url: "{Controller}/{Action}", 
                defaults: new {
                    Controller = "Home",
                    Action = "Index"
                });
        }
    }
}
