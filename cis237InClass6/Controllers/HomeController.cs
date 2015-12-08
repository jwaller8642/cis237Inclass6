using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cis237InClass6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            // Added this call "SomeThingElse: to the view bag
            ViewBag.SomeThingElse = "SomeThing Else";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //Added new method. it will get called by the default route, if i point to /Home/Foo
        public ActionResult Foo()
        {
            //Returns some text
            //return Content("This is my page");
            return View();
        }
    }
}