using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlogGece.Areas.Admin.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Admin/Orders
        public ActionResult Index()
        {
            return Content("Admin Area Orders(controller) , Index(Action)");
        }

        public ActionResult Update()
        {
            return Content("Admin Area Orders(controller) , Update(Action)");
        }
    }
}