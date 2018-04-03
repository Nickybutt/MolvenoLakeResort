#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.Library.Unit.cs
// Created On    ::    29/03/2018 10:38 AM
// Altered On    ::    29/03/2018 10:40 AM
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.ComponentModel;
using MolvenoLakeResort.Library.Core.Enumerations;

#endregion

namespace MolvenoLakeResort.Library.Business_Objects
{
    public class Unit
    {
        public Unit() { }

        [DisplayName("Price")]
        public double Price { get; set; }
        [DisplayName("Amount")]
        public int Amount { get; set; }
        [DisplayName("Measurement")]
        public string MeasurementType { get; set; }
    }
}