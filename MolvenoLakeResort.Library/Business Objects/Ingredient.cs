using System.ComponentModel;
using MolvenoLakeResort.Library.Business_Objects;
using MolvenoLakeResort.Library.Core.Business_Objects;

namespace MolvenoLakeResort.Library.Core
{
    public class Ingredient : ResortItem
    {
        public Ingredient() { }

        [DisplayName("Add on Charge")]
        public double AddOnCharge { get; set; }
        public Unit Unit { get; set; }
        [DisplayName("Cost")]
        public double CostPrice { get; set; }
    }
}