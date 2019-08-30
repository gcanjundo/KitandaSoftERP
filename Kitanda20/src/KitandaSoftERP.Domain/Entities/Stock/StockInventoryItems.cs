using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.Stock
{
    public partial class StockInventoryItems:StockItem
    {
        public int StockInventoryID { get; set; }
        public int StockItemID { get; set; }
        public decimal PriorQuantity { get; set; }
        public decimal QuantityCount { get; set; }
        public decimal QuantityDiference { get; set; }
        public string Acerto { get; set; }
        public int? ProductLotId { get; set; }
        public int? ProductSizeColorID { get; set; }
        public int? ProductSerialNumberID { get; set; } 
        public virtual StockItem StockItem { get; set; }
        public virtual StockInventory StockInventory { get; set; }
        public virtual ProductLots ProductLot { get; set; }
        public virtual ProductColorsSizes ProductSizeColor { get; set; }
        public virtual ProductSerialNumbers ProductSerialNumber { get; set; }

        public StockInventoryItems()
        {
            StockItem = new StockItem();
            StockInventory = new StockInventory();
            ProductLot = new ProductLots();
            ProductSizeColor = new ProductColorsSizes();
            ProductSerialNumber = new ProductSerialNumbers();
        }

    }
}
