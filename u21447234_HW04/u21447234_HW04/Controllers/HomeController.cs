using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u21447234_HW04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Donate()
        {
            ViewBag.Message = "Donate";

            return View();
        }

        public ActionResult Volunteer()
        {
            ViewBag.Message = "Volunteer";

            return View();
        }

        public ActionResult Petition()
        {
            ViewBag.Message = "Petition";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}