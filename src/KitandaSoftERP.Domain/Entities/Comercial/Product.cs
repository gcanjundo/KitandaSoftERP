using KitandaSoftERP.Domain.Entities.Academica;
using KitandaSoftERP.Domain.Entities.Contabilidade;
using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Entities.Stock;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class Product : BaseEntity
    {
        public int ProductID { get; set; }
        public string ProductReference { get; set; }
        public int ProductCategoryID { get; set; }
        public string PhotoPath { get; set; }
        public byte[] Photo { get; set; }
        public string ProductType { get; set; }
        public int UnitOfMensureBaseID { get; set; }
        public int TaxID { get; set; }
        public int MarkID { get; set; }
        public decimal PriceCost { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal ProfitMargin { get; set; }
        public bool MoveStock { get; set; } 
        public DateTime ValidateDate { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public decimal Volume { get; set; }
        public DateTime ManufactureDate { get; set; }
        public bool OnlyKitchenOrder { get; set; }
        public bool AllowDevolution { get; set; }
        public decimal ProductDiscount { get; set; }
        public bool AllowLote { get; set; }
        public bool AllowDimensions { get; set; }
        public bool IsComposed { get; set; }
        public bool MultiPrices { get; set; }
        public bool Discontinued { get; set; }
        public DateTime LastPurchase { get; set; }
        public DateTime LastSale { get; set; }
        public int ProductBaseID { get; set; }
        public string Dimension1 { get; set; }
        public string Dimension2 { get; set; }
        public string Dimension3 { get; set; }
        public bool AllowedForPOS { get; set; }
        public decimal PesoLiquido { get; set; }
        public int DeadLineDelivery { get; set; }
        public string TecnicalNotes { get; set; }
        public int VendorID { get; set; }
        public decimal VendorComission { get; set; }
        public decimal Calories { get; set; }
        public decimal Proteins { get; set; }
        public decimal QuantityBase { get; set; }
        public string ComposeType { get; set; }
        public decimal ComposePrice { get; set; }
        public bool IsExternal { get; set; }
        public int ExternalEntityID { get; set; }
        public bool OnlyByOrder { get; set; }
        public int SetupTime { get; set; }
        public int AccountPlanSalesID { get; set; }
        public int AccountPlanPurchaseID { get; set; }
        public int AccountPlanStockItemID { get; set; }
        public int AccountPlanPurchaseRefundID { get; set; }
        public int AccountPlanSalesRefundID { get; set; }
        
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Entity ExternalEntity { get; set; }
        public virtual UnitOfMeasure UnitOfMensureBase { get; set; }
        public virtual StockItem StockItem { get; set; } 
        public virtual ICollection<ProductPriceList> PriceList { get; set; }
        public virtual ICollection<SalesInvoiceLines> SalesInvoiceLines { get; set; }

        public Product()
        {
            ProductCategory = new ProductCategory();
            Branch = new Branch();
            ExternalEntity = new Entity();
            UnitOfMensureBase = new UnitOfMeasure();
            StockItem = new StockItem();
            PriceList = new HashSet<ProductPriceList>();
            SalesInvoiceLines = new HashSet<SalesInvoiceLines>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
