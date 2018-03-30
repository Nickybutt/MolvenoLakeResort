using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MolvenoLakeResort.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Info()
        {
            ViewBag.Message = "Your application info page.";

            return View();

        }

        public ActionResult Restaurant()
        {
            ViewBag.Message = "Your application restaurant page.";

            return View();

        }

        public ActionResult Menu()
        {
            ViewBag.Message = "Your application Menu page.";

            return View();

        }

        public ActionResult Dish()
        {
            ViewBag.Message = "Your application Dish page.";

            return View();

        }

        public ActionResult Ingredienth()
        {
            ViewBag.Message = "Your application Ingredient page.";

            return View();

        }
    }
}