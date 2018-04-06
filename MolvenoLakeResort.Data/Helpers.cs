#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.Data.Helpers.cs
// Created On    ::    03/04/2018 2:15 PM
// Altered On    ::    05/04/2018 2:02 PM
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Configuration;

#endregion

namespace MolvenoLakeResort.Data
{
    public class Helpers
    {
        public static string GetRDSConnectionString()
        {

            var dbname = "lakeresort";

            if (string.IsNullOrEmpty(dbname)) return null;

            var username = "root";
            var password = "M4st3r#!";
            var hostname = "molveno.crempvy9jvuy.eu-west-2.rds.amazonaws.com";
            var port = "3306";

            //return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
            return $"Server={hostname};Database={dbname};Uid={username};Pwd={password};";
        }
    }
}