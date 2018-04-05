#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.Data.Helpers.cs
// Created On    ::    03/04/2018 2:15 PM
// Altered On    ::    05/04/2018 11:26 AM
// By            ::    Arjan Crielaard

#endregion

namespace MolvenoLakeResort.Data
{
    public class Helpers
    {
        public static string GetRdsConnectionString()
        {
            var dbname = "lakeresort";

            if (string.IsNullOrEmpty(dbname)) return null;

            var username = "root";
            var password = "Breaking#88";
            var hostname = "localhost";
            var port = "3306";

            return $"Server={hostname};Database={dbname};Uid={username};Pwd={password};";
        }
    }
}