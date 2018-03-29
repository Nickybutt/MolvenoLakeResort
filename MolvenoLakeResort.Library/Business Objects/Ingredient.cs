using MolvenoLakeResort.Library.Business_Objects;
using MolvenoLakeResort.Library.Core.Business_Objects;

namespace MolvenoLakeResort.Library.Core
{
    public class Ingredient : ResortItem
    {

        public Ingredient() { }

        public double AddOnCharge { get; set; }
        public Unit Unit { get; set; }
        public double CostPrice { get; set; }
    }
}