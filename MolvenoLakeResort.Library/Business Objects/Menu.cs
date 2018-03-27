using System.Collections.Generic;
using MolvenoLakeResort.Library.Core.Business_Objects;

namespace MolvenoLakeResort.Library.Core
{
    public class Menu : ResortItem
    {
        public Menu()
        {
        }

        public Menu(string name)
            : base(name)
        {
        }

        public Menu(string name, double priceInEuros, List<Dish> dishes, List<Menu> meals)
            : this(name)
        {
            PriceInEuros = priceInEuros;
            Dishes = dishes;
            Meals = meals;
        }

        public double PriceInEuros { get; set; }
        public List<Dish> Dishes { get; set; }
        public List<Menu> Meals { get; set; }
    }
}