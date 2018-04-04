using SimpleBlogWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SimpleBlogWeb.Controllers
{
    public class AuthController :Controller
    {

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("Home");
        }
        //GET Method
        public ActionResult Login()
        {
            return View(new AuthLogin() { Test="This is my test value set in my controller"});
        }

        //Post method of Login action
        [HttpPost]
        public ActionResult Login(AuthLogin form,string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }

            ///we add authentication control from database
            ///
            ///
            ///
            /// we add authentication control from database
            
            FormsAuthentication.SetAuthCookie(form.UserName, true);

            if (!String.IsNullOrWhiteSpace(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return RedirectToRoute("Home");
            
        }

        public ActionResult List()
        {
            List<AuthLogin> data = new List<AuthLogin>();
            data.Add(new AuthLogin() { UserName="ali",Password="duru",Test="deneme"});
            data.Add(new AuthLogin() { UserName = "a", Password = "duru", Test = "deneme" });
            data.Add(new AuthLogin() { UserName = "b", Password = "duru", Test = "deneme" });
            data.Add(new AuthLogin() { UserName = "c", Password = "duru", Test = "deneme" });
            data.Add(new AuthLogin() { UserName = "d", Password = "duru", Test = "deneme" });
            data.Add(new AuthLogin() { UserName = "e", Password = "duru", Test = "deneme" });

            return View(new AuthList() { Users=data}); 
        }
    }
}