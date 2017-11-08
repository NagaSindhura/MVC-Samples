using HelperMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Controllers
{
    public class PersonDemoController : Controller
    {
        // GET: PersonDemo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreatePerson()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePerson(PersonDemo person)
        {
            //hamdle the form Data
            return View();
        }
    }
}