using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleBlogWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            var namespaces =new []{ "SimpleBlogWeb.Controllers" };

            routes.MapRoute("Home", "", new { controller="Posts",action="Index"},namespaces); //Our home page request will be processed  by Posts Controller Index Action
            routes.MapRoute("Login", "login", new { controller = "Auth", action = "Login" },namespaces);
            routes.MapRoute("Logout", "logout", new { controller = "Auth", action = "Logout" }, namespaces);
            routes.MapRoute("List", "userList", new { controller = "Auth", action = "List" },namespaces);
        }
    }
}
