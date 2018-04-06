#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.Data.Services.IService.cs
// Created On    ::    06/04/2018 9:34 AM
// Altered On    ::    06/04/2018 9:34 AM
// By            ::    Arjan Crielaard

#endregion

using System;
using System.Collections.Generic;
using MolvenoLakeResort.Data.Items.Core;
using MolvenoLakeResort.Library.Interfaces;

namespace MolvenoLakeResort.Data.Services.Interfaces
{
    public interface IService<T>
        where T : IResortItem
    {
        bool AddOrUpdate(T obj);
        bool Delete(Guid id);

        T GetItem(Guid id);
        List<T> GetItems();
    }
}