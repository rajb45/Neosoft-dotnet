﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        //GET
        public string Index()
        {
            return "Hello";
        }
        //GET
        public string Welcome(string name, int id=1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", Id:" + id);
        }
        public ActionResult Hello()
        {
            return View();
        }
        //GET
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //GET
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}