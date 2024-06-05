using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Save_Sea.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Message"] = " Hello world";
            return View();

        }
        public ActionResult Index1()
        {
           TempData["Message"] = " Hello world";
            return View();



        }
        public ActionResult Index2()
        {
            TempData["Message"] = " Hello world";
            return RedirectToAction("About");


        }



        public ActionResult Services() {

            return View();
        }

          public ActionResult About()
        {
            return View();
        }
    public ActionResult Contact()
        {
            return View();
        }
    }
}