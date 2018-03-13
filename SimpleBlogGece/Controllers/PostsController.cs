using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//JSON java script object notation
//Web Service -> Banka örneği

namespace SimpleBlogGece.Controllers
{
    public class PostsController : Controller
    {
        // GET: Posts
        public ActionResult Index() //Controller classına tanımlanması gerek. Return type : ActionResult . Public class
        {
            return View(); 
        }
    }
}