using Core3Exercise3_linh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Core3Exercise3_linh.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Car> data = new List<Car>();
            List<Linh> info = new List<Linh>();


            info.Add(new Linh { Name = "Linh Nguyen" });
            info.Add(new Linh { Age = 22 });
            info.Add(new Linh { Hobby = "Video Game" });
            info.Add(new Linh { Music = "K-Pop" });



            data.Add(new Car { CarMaker = "Toyota" });
            data.Add(new Car { CarModel = "Camry LE" });
            data.Add(new Car { CarYear = 2018 });
            data.Add(new Car { CarColor = "Grey" });
            
            MyData Combine = new MyData();          
            Combine.LinhInfo = info;
            Combine.CarData = data;
            
            return View(Combine);
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