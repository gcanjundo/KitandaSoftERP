using KitandaSoftERP.Domain.Entities.Comercial;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Stock
{
    public class StockItem
    {
          
        public int StockItemProductID { get; set; }
        public int StockItemWarehouseID { get; set; }
        public int StockItemSalesUnitofMeasureID { get; set; }
        public int StockItemPurchaseUnitofMeasureID { get; set; }
        public int StockItemStorageUnitofMeasureID { get; set; }
        public int StockItemIncomeUnitofMeasureID { get; set; }
        public int StockItemOutcomeUnitofMeasureID { get; set; }
        public bool StockItemRuptureStockAlert { get; set; }
        public decimal StockItemProductQuantity { get; set; }
        public decimal StockItemCurrentQuantity { get; set; }
        public decimal StockItemMinQuantity { get; set; }
        public decimal StockItemMaxQuantity { get; set; }
        public DateTime StockItemLastIncomeQuantity { get; set; }
        public DateTime StockItemLastOutcomeQuantity { get; set; }
        public DateTime StockItemLastCountQuantity { get; set; }
        public decimal StockItemAveragePriceCost { get; set; }
        public decimal StockItemLastPriceCost { get; set; }
        public virtual Product StockItemProduct { get; set; }
        public virtual Warehouse StockItemWarehouse { get; set; }

        public StockItem()
        {
            StockItemProduct = new Product();
            StockItemWarehouse = new Warehouse();
        }
    }
}
