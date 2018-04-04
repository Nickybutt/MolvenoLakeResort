#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.Library.MolvenoIngredient.cs
// Created On    ::    29/03/2018 2:26 PM
// Altered On    ::    29/03/2018 2:28 PM
// By            ::    Arjan Crielaard

#endregion

using System.ComponentModel;

namespace MolvenoLakeResort.Library.Business_Objects
{
    public class MolvenoIngredient
    {
        [DisplayName("desc.")]
        public string Description { get; set; }
        [DisplayName("brand")]
        public string Brand { get; set; }
        public string Deliverer { get; set; }
        [DisplayName("art. no.")]
        public string ArticleNumber { get; set; }
        [DisplayName("unit")]
        public string Unit { get; set; }
        [DisplayName("quant.")]
        public string Quantity { get; set; }
        [DisplayName("price")]
        public decimal Price { get; set; }
        [DisplayName("v.a.t.")]
        public string Vat { get; set; }
        [DisplayName("pr. p/unit")]
        public decimal PricePerUnit { get; set; }
        public string Category { get; set; }
        [DisplayName("av. stock")]
        public int Stock { get; set; }
        [DisplayName("stock value")]
        public decimal StockWorth { get; set; }
    }
}