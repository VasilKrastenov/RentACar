using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.Controllers
{
    public class AdministrativeController : Controller
    {
        // GET: Administrative
        public ActionResult AddCar()
        {
            return View();
        }

        public ActionResult EditCar()
        {
            return View();
        }
    }
}