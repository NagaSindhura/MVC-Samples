﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Controllers
{
    public class HM3_CustomHelperMethodController : Controller
    {
        // GET: HM3_CustomHelperMethod
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Step1()
        {
            ViewBag.Fruits = new String[] { "Grapes", "Apple", "Orange" };
            ViewBag.States = new String[] { "TS", "Simla", "AP" };

            return View();
        }

        public ActionResult Step2()
        {
            ViewBag.Fruits = new String[] { "Grapes", "Apple", "Orange" };
            ViewBag.States = new String[] { "TS", "Simla", "AP" };

            return View();
        }
        public ActionResult Step3()
        {
            ViewBag.Fruits = new String[] { "Grapes", "Apple", "Orange" };
            ViewBag.States = new String[] { "TS", "Simla", "AP" };

            return View();
        }

        public ActionResult Step4()
        {
            string message = "This is an HTML element: <input>";

            return View((object)message);
        }

        public ActionResult Step5()
        {
            string message = "This is an HTML element: <input>";

            return View((object)message);
        }

        public ActionResult Step6()
        {
            string message = "This is an HTML element: <input>";

            return View((object)message);
        }

        public ActionResult Step7()
        {
            string message = "This is an HTML element: <input>";

            return View((object)message);
        }
    }
}