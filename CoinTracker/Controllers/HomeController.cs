﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace CoinTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.Message = "Fifty States? No Problem!";

            return View();
        }

        public ActionResult AccountHome()
        {

            ViewBag.Title = "Acocunt Home";
            ViewBag.Message = "Welcome Back User";

            return View();
        }

        public ActionResult AccountCreated()
        {

            ViewBag.Title = "Account Created";
            ViewBag.Message = "Account Creation Successful";

            return View();
        }

        [HttpPost]
        public ActionResult LogIn()
        {
            return RedirectToAction("AccountHome");
        }

        [HttpPost]
        public ActionResult CreateAccount()
        {
            return RedirectToAction("AccountCreated");

        }

    }
}
