using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CafeZiraldo.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ProcessSignUp(string UName, string Email)
        {
            ViewBag.Message = "Thanks " + UName+ " ("+Email+")";
            return View("Index");
            // return Redirect("https://www.google.com");
        }


    }
}