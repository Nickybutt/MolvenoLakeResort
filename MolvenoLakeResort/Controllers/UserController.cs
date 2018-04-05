#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.UserController.cs
// Created On    ::    05/04/2018 9:59 AM
// Altered On    ::    05/04/2018 10:28 AM
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Web.Mvc;
using MolvenoLakeResort.Library.Authentication;

#endregion

namespace MolvenoLakeResort.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: Register
        public ActionResult Register()
        {
            var model = new User();
            return View(model);
        }

        // POST: Register
        [HttpPost]
        public ActionResult Register(User model)
        {
            return model.IsValid ? View("Index") : View();
        }

        public void Login()
        {
        }

        public void Logout()
        {
        }
    }
}