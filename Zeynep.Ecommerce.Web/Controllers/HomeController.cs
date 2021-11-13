using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zeynep.Ecommerce.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Title = "Login";

            return View();
        }


        public ActionResult SignUp()
        {
            ViewBag.Title = "SignUp";

            return View();
        }


        public ActionResult Cart()
        {
            ViewBag.Title = "Cart";

            return View();
        }
    }
}
