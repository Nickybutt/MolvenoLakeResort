#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.DishController.cs
// Created On    ::    04/04/2018 7:29 AM
// Altered On    ::    04/04/2018 8:04 AM
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using MolvenoLakeResort.Library.Business_Objects;
using MolvenoLakeResort.Library.Helpers;

#endregion

namespace MolvenoLakeResort.Controllers
{
    public class DishController : Controller
    {
        private static readonly List<MolvenoIngredient> molvenoIngredients =
            DataHelper.ConvertCsv(ConfigurationManager.AppSettings.GetExcelPath());


        // GET: Dish
        public ActionResult Index()
        {
            ViewBag.ShowHeader = true;
            var dishes = molvenoIngredients.ToDishes();
            return View(dishes.Where(i => i.Deleted == false).ToList());
        }

        // GET: Dish/Details/5
        public ActionResult Details(Guid id)
        {
            ViewBag.ShowHeader = true;
            ViewBag.ReadOnly = false;
            var dishes = molvenoIngredients.ToDishes();
            var model = dishes.FirstOrDefault(i => i.Id == id);
            return View(model);
        }

        // GET: Dish/Create
        public ActionResult Create()
        {
            return View("Details");
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
                return View("Details");
            }
        }

        // GET: Dish/Save/5
        public ActionResult Edit(int id)
        {
            return View("Details");
        }

        // POST: Dish/Save/5
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
                return View("Details");
            }
        }

        // GET: Dish/Delete/5
        public ActionResult Delete(int id)
        {
            return View("Details");
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
                return View("Details");
            }
        }
    }
}