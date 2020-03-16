using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookstore.Util;
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
            return "This is your number"+i;
        }

        [HttpGet]
        public ActionResult E()
        {
            return View();
        }
        public ActionResult GetHtml()
        {
            return new HtmlResult("<h2>Hello, world. This is my page)))</h2>");
        }
        public ActionResult GetImage()
        {
            string path = "../Image/imgh.jpg";
            return new ImageResult(path);
        }
    }
}