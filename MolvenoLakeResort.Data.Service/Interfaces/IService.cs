using MolvenoLakeResort.Data.Items.Core;
using System;
using System.Collections.Generic;

namespace MolvenoLakeResort.Data.Service.Interfaces
{
    public interface IService<T>
        where T: IdentifiableBaseObject
    {
        // CRUD
        bool AddOrUpdate(IdentifiableBaseObject obj);
        bool Delete(Guid Id);
        IdentifiableBaseObject GetItem();
        List<T> GetItems();
    }
}
