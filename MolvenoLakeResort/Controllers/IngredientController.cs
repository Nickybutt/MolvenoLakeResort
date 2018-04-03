using MolvenoLakeResort.Library.Core;
using MolvenoLakeResort.Library.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;

namespace MolvenoLakeResort.Controllers
{
    public class IngredientController : Controller
    {
        private static readonly List<Ingredient> ingredients = Converter.ConvertCsv(ConfigurationManager.AppSettings.GetExcelPath()).ToIngredients();
        // GET: Ingredient
        public ActionResult Index()
        {
            ViewBag.ShowHeader = true;
            return View(ingredients);
        }

        // GET: Ingredient/Details/5
        public ActionResult Details(Guid id)
        {
            ViewBag.ReadOnly = true;

            var model = ingredients.FirstOrDefault(m => m.Id == id);
            return View(model);
        }

        // GET: Ingredient/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ingredient/Create
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

        // GET: Ingredient/Edit/5
        public ActionResult Edit(Guid id)
        {
            ViewBag.ReadOnly = false;
            return View();
        }

        // POST: Ingredient/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
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

        // GET: Ingredient/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ingredient/Delete/5
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
