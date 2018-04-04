using System.Collections.Generic;
using MolvenoLakeResort.Library.Core.Business_Objects;

namespace MolvenoLakeResort.Library.Core
{
    public class Menu : ResortItem
    {
        public Menu()
        {
        }

        public decimal PriceInEuros { get; set; }
        public List<Dish> Dishes { get; set; }
        public List<Menu> Meals { get; set; }
    }
}