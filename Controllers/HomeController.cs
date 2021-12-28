﻿using System;
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
            ViewBag.Message = "Your application description page here.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page here.";

            return View();
        }
    }
}