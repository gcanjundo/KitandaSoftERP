using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Entities.Stock;
using System;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class SalesInvoiceLines : BaseEntity
    {
        public int LineID { get; set; }
        public int LineNumberOrder { get; set; }
        public int LineInvoiceID { get; set; }
        public int LineProductID { get; set; }
        public int LineTaxID { get; set; } 
        public int LineRetentionID { get; set; }
        public decimal Quantity { get; set; }
        public string UnitMensureID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TaxBase { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal DebitAmount { get; set; }
        public int DiscountID { get; set; }
        public decimal DiscountLine { get; set; }
        public decimal FinanceDiscount { get; set; }
        public decimal CustomerDiscount { get; set; }
        public decimal ComercialDiscount { get; set; }
        public decimal DiscountLineAmount { get; set; }
        public decimal FinanceDiscountAmount { get; set; }
        public decimal CustomerDiscountAmount { get; set; }
        public decimal ComercialDiscountAmount { get; set; }
        public decimal TotalDiscountAmount { get; set; }
        public decimal TaxPayable { get; set; }
        public decimal NetTotal { get; set; }
        public decimal GrossTotal { get; set; }
        public decimal DeliveryQuantity { get; set; }
        public int ComposeID { get; set; }
        public int LoteID { get; set; }
        public int DimensionID { get; set; }
        public int SerialNumberID { get; set; }
        public decimal RetentionBase { get; set; }
        public decimal RetentionAmount { get; set; }
        public int DocumentOriginLineID { get; set; } 
        public int DocumentTransportLineID { get; set; } 
        public DateTime DeliveryDate { get; set; }
        public string DeliveredBy { get; set; }
        public int WarehouseID { get; set; }
        public decimal CostPrice { get; set; }
        public decimal PriorStockQuantity { get; set; }

        public virtual SalesInvoice SalesInvoice { get; set; }
        public virtual Product Product { get; set; }
        public virtual Warehouse Warehouse { get; set; }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
