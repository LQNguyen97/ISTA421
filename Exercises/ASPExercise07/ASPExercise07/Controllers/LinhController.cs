using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using ASPExercise07.Models;
using Microsoft.Ajax.Utilities;

namespace ASPExercise07.Controllers
{
    public class LinhController : Controller
    {
        // GET: Linh
        public ActionResult Index()
        {
            Linh data = new Linh()
            {
                MyName = "Linh Nguyen",
                Gender = "Male",
                Branches = "U.S. Marine Corps",
                MOS = "1345 Heavy Equipment Operator"
            };
            return View();
        }
    }
}