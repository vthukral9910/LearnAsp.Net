﻿using OdeToFood.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel();
            // var  name = HttpContext.Request.QueryString["name"];
            model.name = name ?? "no name";
            
            model.Message = ConfigurationManager.AppSettings["message"];

            return View(model);
        }
    }
}