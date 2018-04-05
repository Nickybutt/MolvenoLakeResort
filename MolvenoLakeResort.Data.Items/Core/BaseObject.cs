#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.Data.Items.BaseObject.cs
// Created On    ::    05/04/2018 11:51 AM
// Altered On    ::    05/04/2018 11:58 AM
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace MolvenoLakeResort.Data.Items.Core
{
    public class BaseObject : IdentifiableBaseObject
    {
        public string Name { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Altered { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid AlteredBy { get; set; }
    }
}