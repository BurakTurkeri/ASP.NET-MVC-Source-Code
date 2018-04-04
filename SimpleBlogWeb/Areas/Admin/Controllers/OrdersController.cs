using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlogWeb.Areas.Admin.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Admin/Orders
        public ActionResult Index()
        {
            return Content("Admin Area Orders Controller Index Action");
        }

        public ActionResult Update()
        {
            return Content("Admin Area Orders Controller Update Action");
        }
    }
}