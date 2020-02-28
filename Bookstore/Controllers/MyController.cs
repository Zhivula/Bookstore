using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bookstore.Controllers
{
    public class MyController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string E(int i=10)
        {
            return "This is your IP";
        }

        [HttpGet]
        public ActionResult E()
        {
            return View();
        }
    }
}