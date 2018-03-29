using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolvenoLakeResort.Data
{
    public class Helpers
    {
        public static string GetRDSConnectionString()
        {
            var appConfig = ConfigurationManager.AppSettings;

            string dbname = "lakeresort";

            if (string.IsNullOrEmpty(dbname)) return null;

            string username = "master";
            string password = "M4st3r!#";
            string hostname = "molveno.crempvy9jvuy.eu-west-2.rds.amazonaws.com";
            string port = "3306";

            return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }
    }
}
