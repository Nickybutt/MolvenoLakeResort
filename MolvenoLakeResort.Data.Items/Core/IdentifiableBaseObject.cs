#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.Data.Items.IdentifiableBaseObject.cs
// Created On    ::    05/04/2018 11:51 AM
// Altered On    ::    05/04/2018 11:52 AM
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace MolvenoLakeResort.Data.Items.Core
{
    public class IdentifiableBaseObject
    {
        protected IdentifiableBaseObject()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
    }
}