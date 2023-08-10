﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["Username"] = "Vikas";
            return View();
        }

        public ActionResult About()
        {
            Session["Username"] = "Vikas";
            ViewBag.Message = " Welcome to Git Project Sync operation .";

            return View();
        }

        public ActionResult Contact()
        {
            Session["Username"] = "Vikas";
            ViewBag.Message = "Git Demo Contact page with contact address";
        
            return View();
        }
    }
}