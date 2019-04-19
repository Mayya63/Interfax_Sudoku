using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sudoku
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{level}",
                defaults: new { controller = "MainView", action = "Index", level = 1 }
            );
            routes.MapRoute(
                name: "OpenCell",
                url: "api/{controller}",
                defaults: new { action = "OpenCell" }
                );

            routes.MapRoute(
                name: "Verify",
                url: "api/{controller}",
                defaults: new { action = "Verify"}
            );
            routes.MapRoute(
               name: "Index",
               url: "{controller}/{action}/{level}",
               defaults: new { controller = "MainView", action = "Load", level = UrlParameter.Optional }
           );
        }
    }
}
