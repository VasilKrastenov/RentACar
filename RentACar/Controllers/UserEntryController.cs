using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.Controllers
{
    public class UserEntryController : Controller
    {
        // GET: Registration
        public ActionResult Registration()
        {
            ViewBag.Title = "Register";

            return View();
        }
        //
        // GET: Login
        public ActionResult Login()
        {
            ViewBag.Title = "Login";

            return View();
        }

        public ActionResult ForgottenPassword()
        {
            return View();
        }

        public ActionResult PasswordReset()
        {
            return View();
        }
    }
}