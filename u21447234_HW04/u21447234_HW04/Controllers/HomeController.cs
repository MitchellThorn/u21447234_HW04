using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21447234_HW04.Models;

namespace u21447234_HW04.Controllers
{
    public class HomeController : Controller
    {
        public static List<Volunteer> vol = new List<Volunteer>();
        TreePlanter vol1TP = new TreePlanter("John Jonny", "john@gmail.com", "314 Stone Lane", "Digging");
        public ActionResult Index()
        {
            return View(vol);
        }

        [HttpGet]
        public ActionResult AssistUs()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AssistUs(string fullName, string email, string address, int Type, string? ttype, string? option, string? area)
        {
            Volunteer newV = null;
            if (Type == 1)
            {
                TreePlanter newT = (TreePlanter)newV;
                newT = new TreePlanter(fullName, email, address, ttype);

                vol.Add(newT);
            }
            else if (Type == 2)
            {
                OceanCleaner newO = new OceanCleaner()
                {
                    FullName = fullName,
                    Email = email,
                    Address = address,
                    Area = area
                };
                vol.Add(newO);
            }
            else if (Type == 3)
            {
                Missionary newM = new Missionary()
                {
                    FullName = fullName,
                    Email = email,
                    Address = address,
                    Option = option
                };
                vol.Add(newM);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Donate()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }
    }
}