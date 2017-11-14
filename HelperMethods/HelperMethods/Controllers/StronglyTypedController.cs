using HelperMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Controllers
{
    public class StronglyTypedController : Controller
    {
        // GET: StronglyTyped
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WhyStronglyTyped()
        {
            ViewBag.FirstName = "FirstName from Viewbag";

            Person person = new Person();

            person.FirstName = "FirstName from PersonObject";
            person.LastName = "LastName from PersonObject";

            return View(person);
        }
    }
}