#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.RestaurantController.cs
// Created On    ::    03/04/2018 2:15 PM
// Altered On    ::    04/04/2018 8:04 AM
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Collections.Generic;
using System.Web.Mvc;
using MolvenoLakeResort.Library.Core;

#endregion

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


        public ActionResult Meals()
        {
            //fetch data
            var ingredients = new List<Ingredient>
            {
                new Ingredient {Name = "Salt", CostPrice = new decimal(0.25)},
                new Ingredient {Name = "Pepper", CostPrice = new decimal(0.15)}
            };

            var dishes = new List<Dish>
            {
                new Dish
                {
                    Ingredients = ingredients,
                    Name = "Pancakes",
                    SuggestedRetailPrice = 4.00m,
                    PriceInEuros = 5.00m,
                    MinimumNumberOfPersons = 1
                },
                new Dish
                {
                    Ingredients = ingredients,
                    Name = "Stamppot",
                    SuggestedRetailPrice = 1.00m,
                    PriceInEuros = 2.00m,
                    MinimumNumberOfPersons = 1
                },
                new Dish
                {
                    Ingredients = ingredients,
                    Name = "Snert",
                    SuggestedRetailPrice = 1.00m,
                    PriceInEuros = 2.00m,
                    MinimumNumberOfPersons = 2
                }
            };

            var dishesRichPeopleFood = new List<Dish>
            {
                new Dish
                {
                    Ingredients = ingredients,
                    Name = "Kebab",
                    SuggestedRetailPrice = 2.35m,
                    PriceInEuros = 3.35m,
                    MinimumNumberOfPersons = 1
                },
                new Dish
                {
                    Ingredients = ingredients,
                    Name = "Kapsalon",
                    SuggestedRetailPrice = 6.00m,
                    PriceInEuros = 9.00m,
                    MinimumNumberOfPersons = 1
                },
                new Dish
                {
                    Ingredients = ingredients,
                    Name = "Roti",
                    SuggestedRetailPrice = 2.50m,
                    PriceInEuros = 3.00m,
                    MinimumNumberOfPersons = 4
                }
            };

            var model = new List<Menu>
            {
                new Menu {Dishes = dishes, PriceInEuros = 12.35m, Name = "Pancake fiesta"},
                new Menu {Dishes = dishesRichPeopleFood, PriceInEuros = 299.95m, Name = "Rich people food"}
            };

            ViewBag.ShowHeader = false;

            //push to view
            return View(model);
        }

        public ActionResult Menu()
        {
            //fetech data
            //push to view
            return View();
        }
    }
}