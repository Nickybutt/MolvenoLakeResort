#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.IngredientController.cs
// Created On    ::    03/04/2018 9:07 AM
// Altered On    ::    03/04/2018 10:30 AM
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using MolvenoLakeResort.Library.Core;
using MolvenoLakeResort.Library.Helpers;

#endregion

namespace MolvenoLakeResort.Controllers
{
    public class IngredientController : Controller
    {
        private static readonly List<Ingredient> ingredients =
            Converter.ConvertCsv(ConfigurationManager.AppSettings.GetExcelPath()).ToIngredients();

        private static Guid currentId;
        
        // GET: Ingredient
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.ShowHeader = true;
            return View(ingredients.Where(i => i.Deleted == false).ToList());
        }

        // GET: Ingredient/Details/id
        [HttpGet]
        public ActionResult Details(Guid id)
        {
            ViewBag.ReadOnly = true;
            var model = ingredients.FirstOrDefault(i => i.Id == id);
            return View(model);
        }

        // GET: Ingredient/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.ReadOnly = false;
            return View("Details", new Ingredient());
        }

        // GET: Ingredient/Edit/5
        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            ViewBag.ReadOnly = false;
            var model = ingredients.FirstOrDefault(i => i.Id == id);
            return View("Details", model);
        }

        // POST: Ingredient/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, Ingredient newIngredient)
        {
            try
            {

                var oldIngredient = ingredients.FirstOrDefault(i => i.Id == id);
                if (oldIngredient != default(Ingredient))
                    ingredients.Remove(oldIngredient);

                ingredients.Add(newIngredient);
                ViewBag.ReadOnly = true;
                return View("Details", newIngredient);
            }
            catch
            {
                return View("Index");
            }
        }

        // GET: Ingredient/Delete/5
        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            var oldIngredient = ingredients.FirstOrDefault(i => i.Id == id);
            oldIngredient.Deleted = true;
            ViewBag.ShowHeader = true;
            return View("Index");
        }
    }
}