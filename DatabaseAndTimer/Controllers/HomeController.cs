using DatabaseAndTimer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseAndTimer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PersonModel person = new PersonModel();
            person.Name = PersonModel.GetName();
            return View("Index", person);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}