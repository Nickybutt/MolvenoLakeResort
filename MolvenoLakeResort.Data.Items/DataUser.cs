#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.Data.Items.DataUser.cs
// Created On    ::    05/04/2018 11:50 AM
// Altered On    ::    05/04/2018 11:57 AM
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using MolvenoLakeResort.Data.Items.Core;
using MolvenoLakeResort.Data.Items.Interfaces;

#endregion

namespace MolvenoLakeResort.Data.Items
{
    public class DataUser : BaseObject, IDeletable
    {
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public bool RememberMe { get; set; }
        public int UserLevel { get; set; }
        public bool Deleted { get; set; }
    }
}