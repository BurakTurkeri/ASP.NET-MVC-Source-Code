using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleBlogGece
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); //Nasıl bir talep geldiğinde bunun cevaplanmayacağı. 
                                                              //Debugging sırasında taleplerin bulunamadığını söyler.


            routes.MapRoute("Home", "" , new { controller="Posts", action="Index" } ); //Our home page request  will be processed by Posts Controller Index Action
            routes.MapRoute("Login","Login", new { controller = "Auth", action = "Login" } );
            routes.MapRoute("ProductList", "urunler", new { controller = "Products", action = "Listele" });
                            //routname         //url   //------------------Defaults--------------------------------   


            //routes.MapRoute( //Talep geldiğinde hangi controllerın hangi actiona yönleneceğini söyler.
            //  name: "Default",
            // url: "{controller}/{action}/{id}",
            // defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            // );

            // defaultu silmemizin nedeni seo için. örneğin projemizde bir admin vs gibi ekranlar olduğunda default root 
            //kullanışsız olduğundan kendimiz bir maproute oluşturuyoruz. Daha fazla ekran ekleyebilme şansı verdiğinden.
            //To be a controller
            //1-in controllers folder, 2-C# cs class file, 3-public access in class
            
        }
    }
}
