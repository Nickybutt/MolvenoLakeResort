using MolvenoLakeResort.Library.Interfaces;
using System;
using System.Collections.Generic;

namespace MolvenoLakeResort.Library.Core
{
    public class Menu : IResortItem
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public double PriceInEuros { get; set; }
        public List<Dish> Dishes { get; set; }
        public List<Menu> Meals { get; set; }
    }
}
