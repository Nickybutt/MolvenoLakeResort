using MolvenoLakeResort.Library.Interfaces;
using System;

namespace MolvenoLakeResort.Library.Core.Business_Objects
{
    public abstract class ResortItem : IResortItem
    {
        public Guid Id { get; }
        public string Name { get; set; }

        protected ResortItem()
        {
            Id = Guid.NewGuid();
        }

        protected ResortItem(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }
    }
}
