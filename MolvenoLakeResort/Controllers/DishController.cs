using MolvenoLakeResort.Library.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MolvenoLakeResort.Controllers
{
    public class DishController : Controller
    {
        // private static readonly List<Dish> dishes

        private static readonly List<Ingredient> ingredients = new List<Ingredient>()
            {
                new Ingredient {Name = "Salt", CostPrice = 0.25},
                new Ingredient {Name = "Pepper", CostPrice = 0.15},
            };
        //fetch data
        private static readonly List<Dish> dishes = new List<Dish>()
            {
                new Dish{Ingredients = ingredients,Name = "Pancakes",SuggestedRetailPrice = 4.00,PriceInEuros = 5.00, MinimumNumberOfPersons = 1},
                new Dish{Ingredients = ingredients,Name = "Pizza",SuggestedRetailPrice = 2.00,PriceInEuros = 3.00, MinimumNumberOfPersons = 1},
                new Dish{Ingredients = ingredients,Name = "Paella",SuggestedRetailPrice = 3.50,PriceInEuros = 4.50, MinimumNumberOfPersons = 1},
                new Dish{Ingredients = ingredients,Name = "Stamppot",SuggestedRetailPrice = 1.00,PriceInEuros = 2.00, MinimumNumberOfPersons = 2},
                new Dish{Ingredients = ingredients,Name = "Kebab",SuggestedRetailPrice = 2.35,PriceInEuros = 3.35, MinimumNumberOfPersons = 1},
                new Dish{Ingredients = ingredients,Name = "Kapsalon",SuggestedRetailPrice = 6.00,PriceInEuros = 9.00, MinimumNumberOfPersons = 1},
                new Dish{Ingredients = ingredients,Name = "Roti",SuggestedRetailPrice = 2.50,PriceInEuros = 3.00, MinimumNumberOfPersons = 4},
            };

        // GET: Dish
        public ActionResult Index()
        {
            ViewBag.ShowHeader = true;
            return View(dishes.Where(i => i.Deleted == false).ToList());
        }

        // GET: Dish/Details/5
        public ActionResult Details(Guid id)
        {
            ViewBag.ShowHeader = true;
            ViewBag.ReadOnly = false;
            var model = dishes.FirstOrDefault(i => i.Id == id);
            return View(model);
        }

        // GET: Dish/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dish/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dish/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dish/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dish/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dish/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
