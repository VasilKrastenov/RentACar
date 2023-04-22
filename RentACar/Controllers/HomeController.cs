using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "ICT Car Rental - Home";

            return View();
        }

        public ActionResult Contacts()
        {
            ViewBag.Title = "ICT Car Rental - Contacts";

            return View();
        }

        public ActionResult Cars()
        {
            return View();
        }
    }
}
