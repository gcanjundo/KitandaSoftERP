using KitandaSoftERP.Domain.Entities.Comercial;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Stock
{
    public class ProductSerialNumbers: StockItem
    {
        public int SerialStockItemID { get; set; }
        public string SerialNumber { get; set; }
        public virtual StockItem SerialStockItem { get; set; }

        public ProductSerialNumbers() : base()
        {
            SerialStockItem = new StockItem();
        }


    }
}
