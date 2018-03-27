using MolvenoLakeResort.Library.Core.Business_Objects;

namespace MolvenoLakeResort.Library.Core
{
    public class Ingredient: ResortItem
    {
        public Ingredient(string name)
            :base(name)
        {

        }

        public Ingredient(string name, double addoncharge, double costprice, double unit, double unitPrice)
            :this(name)
        {
            AddOnCharge = addoncharge;
            CostPrice = costprice;
            Unit = unit;
            UnitPrice = unitPrice;
        }

        public double AddOnCharge { get; set; }
        public double CostPrice { get; set; }
        public double Unit { get; set; }
        public double UnitPrice { get; set; }
    }
}
