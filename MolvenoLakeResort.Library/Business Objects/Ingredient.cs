using MolvenoLakeResort.Library.Core.Business_Objects;

namespace MolvenoLakeResort.Library.Core
{
    public class Ingredient : ResortItem
    {
        public Ingredient(string name) : base(name)
        {
        }

        public Ingredient(string name, double addOnCharge, double costPrice, double unit, double unitPrice)
            : this(name)
        {
            AddOnCharge = addOnCharge;

        }

        public double AddOnCharge { get; set; }
    }
}