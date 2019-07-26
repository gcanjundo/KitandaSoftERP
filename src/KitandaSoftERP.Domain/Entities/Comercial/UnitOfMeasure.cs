using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Entities.Stock;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class UnitOfMeasure : BaseEntity
    {
        public decimal Unit { get; set; }
        public virtual ICollection<Product> ProductList { get; set; }
        public virtual ICollection<StockItem> StockItemPurchaseUnitOfMeasureList { get; set; }
        public virtual ICollection<StockItem> StockItemSalesUnitOfMeasureList { get; set; }
        public virtual ICollection<StockItem> StockItemStorageUnitOfMeasureList { get; set; }
        public virtual ICollection<StockItem> StockItemIncomeUnitOfMeasureList { get; set; }
        public virtual ICollection<StockItem> StockItemOutcomeUnitOfMeasureList { get; set; }
        public UnitOfMeasure()
        {
            ProductList = new HashSet<Product>();
            StockItemOutcomeUnitOfMeasureList = new HashSet<StockItem>();
            StockItemIncomeUnitOfMeasureList = new HashSet<StockItem>();
            StockItemPurchaseUnitOfMeasureList = new HashSet<StockItem>();
            StockItemStorageUnitOfMeasureList = new HashSet<StockItem>();
            StockItemSalesUnitOfMeasureList = new HashSet<StockItem>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
