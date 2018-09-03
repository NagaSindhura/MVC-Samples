using System.Web.Mvc;

namespace EventManagement.Controllers
{
    public class AccountController : Controller
    {
        //// GET: Account
        //public ActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public ActionResult LogIn()
        {


            return View();

        }


        [HttpPost]
        public ActionResult LogIn(FormCollection form)
        {
            return View();

        }
    }
}