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
        public decimal Taxrate { get; private set; }
        public decimal UnitPrice { get; private set; }

        public ProductEntity(string name, int? colorId, int supplierId, int quantityPerOuter, decimal? recommendedRetailPrice,
            bool isChillerStock, int unitPackageId, int outerPackeageId, int leadTimeDays, decimal typicalWeightPerUnit, decimal taxrate,
            decimal unitPrice)
        {
            ValidatePrices(unitPrice, recommendedRetailPrice);
            ValidateName(name);
            ValidateTaxRate(taxrate);
            ValidatePerOuter(quantityPerOuter);
            ValidateLeadTime(leadTimeDays);
            ValidateWeight(typicalWeightPerUnit);
            ValidateIDS(supplierId, unitPackageId, outerPackeageId, colorId);

            UnitPrice = unitPrice;
            RecommendedRetailPrice = recommendedRetailPrice;
            Name = name;
            ColorId = colorId;
            SupplierId = supplierId;
            QuantityPerOuter = quantityPerOuter;
            IsChillerStock = isChillerStock;
            UnitPackageId = unitPackageId;
            OuterPackeageId = outerPackeageId;
            LeadTimeDays = leadTimeDays;
            TypicalWeightPerUnit = typicalWeightPerUnit;
            Taxrate = taxrate;
            
        }

        //p1 , p2 
        private void ValidatePrices(decimal unitPrice, decimal? recommendedRetailPrice)
        {
            
            if (unitPrice <= 0)
            {
                throw new ArgumentException("precio unitario debe ser mayor a 0");
            }

            if(recommendedRetailPrice.HasValue && recommendedRetailPrice < unitPrice)
            {
                throw new ArgumentException("precio unitario debe ser igual o menor a precio recomendando");
            }

        }
        //p3
        public void UpdatePrice(decimal unitPrice, decimal? recommendedRetailPrice)
        {
            ValidatePrices(unitPrice, recommendedRetailPrice);
            UnitPrice = unitPrice;
            RecommendedRetailPrice = recommendedRetailPrice;
        }
        //p4
        private void ValidateName(string name)
        {

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("el nombre del producto es obligatorio");
            }
            if (name.Length > 100)
            {
                throw new ArgumentException("el nombre del producto no puede exceder los 100 caracteres");
            }
        }
        //p5
        private void ValidateTaxRate(decimal taxRate)
        {
            if (taxRate < 0 || taxRate > 100)
            {
                throw new ArgumentException("el impuesto debe estar entre 0 y 100");
            }
        }
        //p6
        private void ValidatePerOuter(int quantityPerOuter)
        {
            if (quantityPerOuter <= 0)
            {
                throw new ArgumentException("la cantidad de unidades por caja debe ser mayor a  0");
            }
        }
        //p7
        private void ValidateLeadTime(int leadTimeDays)
        {
            if (leadTimeDays < 0)
            {
                throw new ArgumentException("el tiempo de entrega no puede ser negativo");
            }
        }
        //p8
        private void ValidateWeight(decimal typicalWeightPerUnit)
        {
            if (typicalWeightPerUnit <= 0)
            {
                throw new ArgumentException("el peso por unidad debe ser mayor a 0");
            }
        }
        //p9
         private void ValidateIDS(int supplierId, int unitPackageId, int outerPackageId, int? colorId)
        {
            if (supplierId <= 0)
            {
                throw new ArgumentException("el id del proveedor debe ser mayor a 0");
            }
            if (unitPackageId <= 0)
            {
                throw new ArgumentException("el id del paquete de unidad debe ser mayor a 0");
            }
            if (outerPackageId <= 0)
            {
                throw new ArgumentException("el id del paquete exterior debe ser mayor a 0");
            }
            if (colorId.HasValue && colorId <= 0)
            {
                throw new ArgumentException("el id del color debe ser mayor a 0");
            }
        }
        

    }
}
