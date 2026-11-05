using System;
using System.Collections.Generic;

using System.Text;

namespace Domain
{
    public class ProductEntity
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int? ColorId { get; private set; }
        public int SupplierId { get; private set; }
        public int QuantityPerOuter { get; private set; }
        public decimal? RecommendedRetailPrice { get; private set; }
        public bool IsChillerStock { get; private set; }
        public int UnitPackageId { get; private set; }
        public int OuterPackeageId { get; private set; }
        public int LeadTimeDays { get; private set; }
        public decimal TypicalWeightPerUnit { get; private set; }
        public int TaxrateId { get; private set; }
        public decimal UnitPrice { get; private set; }




    }
}
