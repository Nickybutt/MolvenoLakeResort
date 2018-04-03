using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MolvenoLakeResort.Library.Core;
using MolvenoLakeResort.Library.Helpers;

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

        public ActionResult MolvenoIngredients()
        {
            return View(Converter.ConvertCsv(ConfigurationManager.AppSettings.GetExcelPath()));
        }

        public ActionResult Ingredients()
        {
            //fetch data
            var molvenoIngredients = Converter.ConvertCsv(ConfigurationManager.AppSettings.GetExcelPath());
            var model = molvenoIngredients.ToIngredients();
            //push to view
            ViewBag.ShowHeader = true;
            return View(model);
        }

        public ActionResult Dishes()
        {
                
            var ingredients = new List<Ingredient>()
            {
                new Ingredient {Name = "Salt", CostPrice = 0.25},
                new Ingredient {Name = "Pepper", CostPrice = 0.15},
            };
            //fetch data
            var model = new List<Dish>()
            {
                new Dish{Ingredients = ingredients,Name = "Pancakes",SuggestedRetailPrice = 4.00,PriceInEuros = 5.00, MinimumNumberOfPersons = 1},
                new Dish{Ingredients = ingredients,Name = "Pizza",SuggestedRetailPrice = 2.00,PriceInEuros = 3.00, MinimumNumberOfPersons = 1},
                new Dish{Ingredients = ingredients,Name = "Paella",SuggestedRetailPrice = 3.50,PriceInEuros = 4.50, MinimumNumberOfPersons = 1},
                new Dish{Ingredients = ingredients,Name = "Stamppot",SuggestedRetailPrice = 1.00,PriceInEuros = 2.00, MinimumNumberOfPersons = 2},
                new Dish{Ingredients = ingredients,Name = "Kebab",SuggestedRetailPrice = 2.35,PriceInEuros = 3.35, MinimumNumberOfPersons = 1},
                new Dish{Ingredients = ingredients,Name = "Kapsalon",SuggestedRetailPrice = 6.00,PriceInEuros = 9.00, MinimumNumberOfPersons = 1},
                new Dish{Ingredients = ingredients,Name = "Roti",SuggestedRetailPrice = 2.50,PriceInEuros = 3.00, MinimumNumberOfPersons = 4},
            };


            ViewBag.ShowHeader = false;
            //push to view
            return View(model);
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