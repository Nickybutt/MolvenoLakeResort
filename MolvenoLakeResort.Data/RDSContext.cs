#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.Data.RDSContext.cs
// Created On    ::    28/03/2018 11:15 AM
// Altered On    ::    28/03/2018 11:15 AM
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Data.Entity;

#endregion

namespace MolvenoLakeResort.Data
{
    public class RDSContext : DbContext
    {
        public RDSContext()
            : base(Helpers.GetRDSConnectionString())
        {
        }

        public static RDSContext Create()
        {
            return new RDSContext();
        }
    }
}