using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Shared.ValueObject;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Stock
{
    public class Warehouse : BaseEntity
    {
        public int WarehouseID { get; set; }
        public int WarehouseLocationID { get; set; }
        public Address WarehouseAddress { get; set; }
        public bool WarehouseMinimalStockAlert { get; set; }
        public bool WarehouseAllowNegativeStock { get; set; }
        public bool WarehouseNegatiStockAlert { get; set; }
        public string WarehouseType { get; set; }
        public bool WarehousePOSAllowed { get; set; }
        public bool DeniedForSales { get; set; }
        public bool DeniedForPurchase { get; set; }
        public bool DeniedForIncome { get; set; }
        public bool DeniedForOutCome { get; set; }
        public virtual Warehouse WarehouseLocation { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual ICollection<StockItem> StockItemList { get; set; }
        public virtual ICollection<SalesInvoice> SalesInvoiceList { get; set; }
        public virtual ICollection<SalesInvoiceLines> SalesInvoiceLines { get; set; }

        public Warehouse()
        {
            WarehouseLocation = new Warehouse();
            Branch = new Branch();
            StockItemList = new HashSet<StockItem>();
            SalesInvoiceList = new HashSet<SalesInvoice>();
            SalesInvoiceLines = new HashSet<SalesInvoiceLines>();
        }
        
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
