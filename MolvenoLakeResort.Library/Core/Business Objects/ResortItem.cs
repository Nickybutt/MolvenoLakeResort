using MolvenoLakeResort.Library.Interfaces;
using System;
using System.ComponentModel;

namespace MolvenoLakeResort.Library.Core.Business_Objects
{
    public abstract class ResortItem : IResortItem
    {
        public Guid Id { get; }
        public bool Deleted { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }

        protected ResortItem()
        {
            Id = Guid.NewGuid();
        }
    }
}
