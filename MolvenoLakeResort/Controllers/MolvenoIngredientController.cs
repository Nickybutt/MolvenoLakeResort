using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.Mvc;
using MolvenoLakeResort.Library.Core;
using MolvenoLakeResort.Library.Helpers;
using MolvenoLakeResort.Library.Business_Objects;
using X.PagedList;

namespace MolvenoLakeResort.Controllers
{
    public class MolvenoIngredientController : Controller
    {
        private static readonly List<Ingredient> ingredient =
            Converter.ConvertCsv(ConfigurationManager.AppSettings.GetExcelPath()).ToIngredients();

        // GET: MolvenoIngredient
        public ActionResult Index(int? page)
        {
            ViewBag.ShowHeader = true;
            var pageNumber = page ?? 1;
            var model = ingredient.ToPagedList(pageNumber, 10);
            return View(model);
        }

        // GET: MolvenoIngredient/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MolvenoIngredient/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MolvenoIngredient/Create
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

        // GET: MolvenoIngredient/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MolvenoIngredient/Edit/5
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

        // GET: MolvenoIngredient/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MolvenoIngredient/Delete/5
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
