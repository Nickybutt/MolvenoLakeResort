#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.Data.MlrContext.cs
// Created On    ::    05/04/2018 2:23 PM
// Altered On    ::    05/04/2018 2:23 PM
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Data.Entity;
using MolvenoLakeResort.Data.Items;
using MySql.Data.Entity;

#endregion

namespace MolvenoLakeResort.Data
{
    public class MlrContext : DbContext
    {
        public MlrContext()
            : base()
        {
        }

        public DbSet<DataUser> DataUsers { get; set; }

        public static MlrContext Create()
        {
            return new MlrContext();
        }
    }
}