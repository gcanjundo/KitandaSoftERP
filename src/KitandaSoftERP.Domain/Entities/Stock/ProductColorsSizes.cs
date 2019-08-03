using KitandaSoftERP.Domain.Entities.Geral;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Stock
{
    public class ProductColorsSizes:StockItem
    {
        public int StockItemID { get; set; }
        public int ColorID { get; set; }
        public int SizeID { get; set; }
        public virtual StockItem StockItem { get; set; }
        public virtual Colors Color { get; set; }
        public virtual Sizes Size { get; set; }

        public ProductColorsSizes()
        {
            StockItem = new StockItem();
            Color = new Colors();
            Size = new Sizes();
        }
    }
}
