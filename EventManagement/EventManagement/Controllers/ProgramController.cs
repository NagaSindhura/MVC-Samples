using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagement.Controllers
{
    using EventManagement.Models;
    using EventManagement.Models.DTO;

    public class ProgramController : Controller
    {
        private List<ProgramView> p = new List<ProgramView>() { new ProgramView { Name = "hi", Product = "Hello" } };
        //Program P1 = new Program();
        //ProgramView program = new ProgramView();

        // GET: Program
        [HttpGet]
        public ActionResult CreateProgram()
        {


            return View(p);
        }

        [HttpPost]
        public ActionResult CreateProgram(FormCollection formCollection)
        {
            //Program program = new Program();
            ProgramView program1 = new ProgramView();

            program1.Name = formCollection["Name"];
            program1.Product = formCollection["Product"];

            p.Add(program1);

            return View(p);
        }

        public ActionResult GetPrograms()
        {
            //P1.Name = "Hi";
            //P1.Product = "hh";

            //p.Add(P1);

            //return p;
            return View( p);

        }
    }
}