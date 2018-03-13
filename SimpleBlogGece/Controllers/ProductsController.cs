using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlogGece.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return Content("Products controller Index view");
        }

        public ActionResult Listele()
        {
            string urunlistesi = "";
            for (int i=0; i<50;i++)
            {
                urunlistesi += string.Format("urun{0} - fiyatı : {1}", i + 1, new Random().NextDouble() * 1000);
            }
            return Content("Ürünler Listeleniyor." + urunlistesi);
        }
    }
}