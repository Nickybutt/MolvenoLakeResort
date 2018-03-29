#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.Library.MolvenoIngredient.cs
// Created On    ::    29/03/2018 2:26 PM
// Altered On    ::    29/03/2018 2:28 PM
// By            ::    Arjan Crielaard

#endregion

namespace MolvenoLakeResort.Library.Business_Objects
{
    public class MolvenoIngredient
    {
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Deliverer { get; set; }
        public string ArticleNumber { get; set; }
        public string Unit { get; set; }
        public string Quantity { get; set; }
        public double Price { get; set; }
        public string Vat { get; set; }
        public double PricePerUnit { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
        public double StockWorth { get; set; }
    }
}