using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgroProductProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description pages here";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact pages.";

            return View();
        }
    }
}