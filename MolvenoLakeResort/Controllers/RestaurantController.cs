using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MolvenoLakeResort.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Index()
        {
            //fetech data
            //push to view
            return View();
        }

        // GET: Restaurant
        public ActionResult Dish()
        {
            //fetech data
            //push to view
            return View();
        }

        public ActionResult Meals()
        {
            return View();
        }

        public ActionResult Ingredient()
        {
            return View();
        }
    }
}