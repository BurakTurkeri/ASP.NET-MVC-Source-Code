using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlogGece.Areas.Admin.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Admin/Customers
        public ActionResult Index()
        {
            return Content("Customers/Index Action");
        }

        public ActionResult Update()
        {
            return Content("Customers/Update Action");
        }

        public ActionResult List()
        {
            return Content("Customers/List Action");
        }
    }
}