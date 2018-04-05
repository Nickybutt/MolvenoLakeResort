#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.Data.MLRContext.cs
// Created On    ::    28/03/2018 11:15 AM
// Altered On    ::    28/03/2018 11:15 AM
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Data.Entity;
using MolvenoLakeResort.Data.Items;

#endregion

namespace MolvenoLakeResort.Data
{
    public class MLRContext : DbContext
    {
        public MLRContext()
            : base(Helpers.GetRdsConnectionString())
        {
        }

        public static MLRContext Create()
        {
            return new MLRContext();
        }

        public DbSet<DataUser> DataUsers { get; set; }
    }
}