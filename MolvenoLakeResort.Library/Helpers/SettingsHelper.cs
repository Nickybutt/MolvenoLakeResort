#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.Library.SettingsHelper.cs
// Created On    ::    29/03/2018 4:14 PM
// Altered On    ::    29/03/2018 4:17 PM
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Collections.Specialized;

#endregion

namespace MolvenoLakeResort.Library.Helpers
{
    public static class SettingsHelper
    {
        public static string GetExcelPath(this NameValueCollection settings)
        {
            var path = settings["IngredientPath"] + "\\" + settings["IngredientFileName"];
            return path;
        }
    }
}