using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MolvenoLakeResort.Library.Core;

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

        public ActionResult Ingredients()
        {
            var model = new List<Ingredient>
            {
                new Ingredient {Name = "Salt", CostPrice = 0.25},
                new Ingredient {Name = "Pepper", CostPrice = 0.15},
                new Ingredient {Name = "Kurma", CostPrice = 0.35},
                new Ingredient {Name = "Saffron", CostPrice = 3.25},
                new Ingredient {Name = "Cumin", CostPrice = 1.25},
                new Ingredient {Name = "Cinnamon", CostPrice = 2.25}
            };
            //fetech data
            //push to view
            return View(model);
        }

        public ActionResult Dishes()
        {
            //fetech data
            //push to view
            return View();
        }

        public ActionResult Meals()
        {
            //fetech data
            //push to view
            return View();
        }

        public ActionResult Menu()
        {
            //fetech data
            //push to view
            return View();
        }
    }
}