using MolvenoLakeResort.Library.Core.Business_Objects;
using System.Collections.Generic;

namespace MolvenoLakeResort.Library.Core
{
    public class Dish : ResortItem
    {
        public Dish(string name)
            : base(name)
        {

        }

        public Dish(string name, double priceInEuros, int minimumNumberOfPersons, List<Ingredient> ingredients, double suggestretailprice, double retailprice, double amount)
            : this(name)
        {
            PriceInEuros = priceInEuros;
            MinimumNumberOfPersons = minimumNumberOfPersons;
            Ingredients = ingredients;
            SuggestedRetailPrice = suggestretailprice;
            RetailPrice = retailprice;
            Amount = amount;
        }

        public double PriceInEuros { get; set; }
        public int MinimumNumberOfPersons { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public double SuggestedRetailPrice { get; set; }
        public double RetailPrice { get; set; }
        public double Amount { get; set; }
    }
}
