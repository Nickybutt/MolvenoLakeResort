using MolvenoLakeResort.Library.Interfaces;
using System;
using System.Collections.Generic;

namespace MolvenoLakeResort.Library.Core
{
    public class Dish : IResortItem
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public double PriceInEuros { get; set; }
        public int MinimumNumberOfPersons { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
