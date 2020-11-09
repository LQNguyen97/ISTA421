using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core3Test10_linh.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Core3Test10_linh.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string name)
        {
            Linh person = new Linh();
            LinhContext db = new LinhContext();
            person = db.Linhs.Single(x => x.Name == name);
            return View(person);
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