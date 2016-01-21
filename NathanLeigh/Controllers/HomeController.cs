using NathanLeigh.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NathanLeigh.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Articles()
        {
            ViewBag.Message = "Medium Articles";

            return View();
        }

        public ActionResult RestaurantApplication()
        {
            ViewBag.Message = "Android Restaurant Application";
            return View();
        }

        public ActionResult LiveLikeACat()
        {
            ViewBag.Message = "Live Like A Cat";

            return View();
        }

        public ActionResult ExponentialDisruption()
        {
            ViewBag.Message = "Exponential Disruption";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}