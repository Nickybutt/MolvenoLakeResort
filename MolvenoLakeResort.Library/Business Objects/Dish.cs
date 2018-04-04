using System.Collections.Generic;
using MolvenoLakeResort.Library.Business_Objects;
using MolvenoLakeResort.Library.Core.Business_Objects;

namespace MolvenoLakeResort.Library.Core
{
    public class Dish : ResortItem
    {
        public Dish()
        {
        }

        public decimal PriceInEuros { get; set; }
        public decimal SuggestedRetailPrice { get; set; }
        public int MinimumNumberOfPersons { get; set; }
        public List<Ingredient> Ingredients { get; set; }

       
    }
}