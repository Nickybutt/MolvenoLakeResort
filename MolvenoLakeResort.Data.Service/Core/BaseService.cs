using System;
using MolvenoLakeResort.Data.Items.Core;
using MolvenoLakeResort.Data.Service.Interfaces;

namespace MolvenoLakeResort.Data.Service.Core
{
    public class BaseService : IService<T>
    {
        public bool AddOrUpdate(IdentifiableBaseObject obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IdentifiableBaseObject GetItem()
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.List<T> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
