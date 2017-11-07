using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Fruits = new String[] { "Grapes", "Apple", "Orange"};
            ViewBag.States = new String[] { "TS", "Simla", "AP" };

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
    }
}