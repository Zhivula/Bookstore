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
            Session["This"] = "this";
            return View();
        }  

        public ActionResult Check()
        {
            return new HttpStatusCodeResult(404);
        }
        public ActionResult E()
        {
            ViewBag.IP = HttpContext.Request.UserHostAddress;
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
        public string ContextData()
        {
            HttpContext.Response.Write("<h2>Здарова))))</h2>");

            string userIP = HttpContext.Request.UserHostAddress;
            string url = HttpContext.Request.RawUrl;
            string userAgent = HttpContext.Request.UserAgent;

            return "<p>userAgent: "+userAgent +"</p>"+
                "<p>userIP: " + userIP + "</p>"+
                "<p>url: " + url + "</p>"; 
        }
        public ActionResult Cookies()
        {
            HttpContext.Response.Cookies["id"].Value = "10";
            ViewBag.id = HttpContext.Request.Cookies["id"].Value;
            return View();
        }
    }
}