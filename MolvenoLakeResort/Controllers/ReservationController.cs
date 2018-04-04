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
    public class ReservationController : Controller
    {

        // GET: Reservation 
        [HttpGet]
        public ActionResult Index(int? page)
        {
            ViewBag.ShowHeader = true;
            var pageNumber = page ?? 1;
            var model = DataHelper.Reservations.ToPagedList(pageNumber, 3);
            return View(model);
        }

        // GET: Reservation/Details/id
        [HttpGet]
        public ActionResult Details(Guid id)
        {
            ViewBag.ReadOnly = true;
            var model = DataHelper.Reservations.FirstOrDefault(i => i.Id == id);
            return View(model);
        }

        // GET: Reservation/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.ReadOnly = false;
            return View("Details", new Reservation());
        }

        // GET: Reservation/Save/5
        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            ViewBag.ReadOnly = false;
            var model = DataHelper.Reservations.FirstOrDefault(i => i.Id == id);
            return View("Details", model);
        }

        // POST: Reservation/Save/5
        [HttpPost]
        public ActionResult Save(Guid id, Reservation newReservation)
        {
            try
            {
                var oldReservation = DataHelper.Reservations.FirstOrDefault(i => i.Id == id);

                if (oldReservation != default(Reservation))
                    DataHelper.Reservations.Remove(oldReservation);

                DataHelper.Reservations.Add(newReservation);
                ViewBag.ReadOnly = true;
                return View("Details", newReservation);
            }
            catch
            {
                return View("Index");
            }
        }

        // GET: Reservation/Delete/5
        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            var oldReservation = DataHelper.Reservations.FirstOrDefault(i => i.Id == id);
            oldReservation.Deleted = true;
            ViewBag.ShowHeader = true;
            return Index(null);
        }
    }
}