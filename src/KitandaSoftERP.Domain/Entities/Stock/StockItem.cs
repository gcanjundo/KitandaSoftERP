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
        public int StockItemSalesUnitOfMeasureID { get; set; }
        public int StockItemPurchaseUnitOfMeasureID { get; set; }
        public int StockItemStorageUnitOfMeasureID { get; set; }
        public int StockItemIncomeUnitOfMeasureID { get; set; }
        public int StockItemOutcomeUnitOfMeasureID { get; set; }
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
        public virtual UnitOfMeasure StockItemPurchaseUnitOfMeasure { get; set; }
        public virtual UnitOfMeasure StockItemSalesUnitOfMeasure { get; set; }
        public virtual UnitOfMeasure StockItemStorageUnitOfMeasure { get; set; }
        public virtual UnitOfMeasure StockItemIncomeUnitOfMeasure { get; set; }
        public virtual UnitOfMeasure StockItemOutComeUnitOfMeasure { get; set; }

        public StockItem():base()
        {
            StockItemProduct = new Product();
            StockItemWarehouse = new Warehouse();
        }
    }
}
