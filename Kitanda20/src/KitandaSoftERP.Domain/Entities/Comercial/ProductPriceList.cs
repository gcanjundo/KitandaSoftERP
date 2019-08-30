using KitandaSoftERP.Domain.Entities.Shared;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class ProductPriceList: BaseEntity
    {
        public int ProductPriceID { get; set; }
        public int ProductID { get; set; }
        public int TablePriceID { get; set; }
        public bool TaxIncluded { get; set; }
        public int TaxID { get; set; }
        public decimal GrossSalesPrice { get; set; }
        public decimal FinalSalesPrice { get; set; }
        public decimal ProfitMargin { get; set; }

        public virtual Product Product { get; set; }
        public virtual TablePrice TablePrice { get; set; }

        public ProductPriceList()
        {
            Product = new Product();
            TablePrice = new TablePrice();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}