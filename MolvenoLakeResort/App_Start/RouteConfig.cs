#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.RouteConfig.cs
// Created On    ::    26/03/2018 12:10 PM
// Altered On    ::    29/03/2018 2:11 PM
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Web.Mvc;
using System.Web.Routing;

#endregion

namespace MolvenoLakeResort
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional}
            );
        }
    }
}