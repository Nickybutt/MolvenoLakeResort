using MolvenoLakeResort.Library.Interfaces;
using System;

namespace MolvenoLakeResort.Library.Core
{
    public class Ingredient: IResortItem
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public double AddOnCharge { get; set; }
    }
}
