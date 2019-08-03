using KitandaSoftERP.Domain.Entities.Comercial;
using System;

namespace KitandaSoftERP.Domain.Entities.Stock
{
    public class ProductLots : StockItem
    {
        public int LotStockItemID { get; set; }
        public string Reference { get; set; } 
        public decimal? LotStockRecepcao { get; set; }
        public decimal? LotStockEntrada { get; set; }
        public decimal? LotStockSaida { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? BillingDeadLineDate { get; set; }

        public virtual StockItem LotStockItem { get; set; }
        public ProductLots():base()
        {
            LotStockItem = new StockItem();
        }
    }
}
