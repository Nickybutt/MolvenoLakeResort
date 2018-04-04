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
using X.PagedList;

#endregion

namespace MolvenoLakeResort.Controllers
{
    public class IngredientController : Controller
    {  
        private static Guid currentId;

        // GET: Ingredient
        [HttpGet]
        public ActionResult Index(int? page)
        {
            ViewBag.ShowHeader = true;
            var pageNumber = page ?? 1;
            var model = DataHelper.Ingredients(ConfigurationManager.AppSettings.GetExcelPath()).Where(i => i.Deleted == false).ToPagedList(pageNumber, 10);
            return View(model);
        }
        
        // GET: MolvenoIngredient
        [HttpGet]
        public ActionResult CoreIndex(int? page)
        {
            var pageNumber = page ?? 1;
            var model = DataHelper.ConvertCsv(ConfigurationManager.AppSettings.GetExcelPath()).ToPagedList(pageNumber, 10);

            return View(model);
        }
        
        // GET: Ingredient/Details/id
        [HttpGet]
        public ActionResult Details(Guid id)
        {
            ViewBag.ReadOnly = true;
            var model = DataHelper.Ingredients(ConfigurationManager.AppSettings.GetExcelPath()).FirstOrDefault(i => i.Id == id);
            return View(model);
        }

        // GET: Ingredient/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.ReadOnly = false;
            return View("Details", new Ingredient());
        }

        // GET: Ingredient/Save/5
        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            ViewBag.ReadOnly = false;
            var model = DataHelper.Ingredients(ConfigurationManager.AppSettings.GetExcelPath()).FirstOrDefault(i => i.Id == id);
            return View("Details", model);
        }

        // POST: Ingredient/Save/5
        [HttpPost]
        public ActionResult Save(Guid id, Ingredient newIngredient)
        {
            try
            {
                var oldIngredient = DataHelper.Ingredients(ConfigurationManager.AppSettings.GetExcelPath()).FirstOrDefault(i => i.Id == id);
                if (oldIngredient != default(Ingredient))
                    DataHelper.Ingredients(ConfigurationManager.AppSettings.GetExcelPath()).Remove(oldIngredient);

                DataHelper.Ingredients(ConfigurationManager.AppSettings.GetExcelPath()).Add(newIngredient);
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
            var oldIngredient = DataHelper.Ingredients(ConfigurationManager.AppSettings.GetExcelPath()).FirstOrDefault(i => i.Id == id);
            oldIngredient.Deleted = true;
            ViewBag.ShowHeader = true;
            return View("Index");
        }
    }
}