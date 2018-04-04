#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.Library.Extensions.cs
// Created On    ::    04/04/2018 11:59 AM
// Altered On    ::    04/04/2018 11:59 AM
// By            ::    Arjan Crielaard

#endregion

using System;

namespace MolvenoLakeResort.Library.Helpers
{
    public static class Extensions
    {
        public static string ToCurrency(this decimal value)
        {
            return $"€ {value:N2}";
        }

        public static string ToDateTime(this DateTimeOffset value)
        {
            return value.ToString("dd/MM/yyyy HH:ss");
        }
    }
}