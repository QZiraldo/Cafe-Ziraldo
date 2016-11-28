using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CafeZiraldo.Models;

namespace CafeZiraldo.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ProcessSignUp(UserData data)
        {
            ViewBag.Message = "Thanks " + data.Uname+ " ("+data.Email+")";
            return View("Index");
            // return Redirect("https://www.google.com");
        }


    }
}