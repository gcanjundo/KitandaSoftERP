using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class TablePrice : BaseEntity
    {
        public virtual ICollection<ProductPriceList> ProductPriceList { get; set; }
        public TablePrice()
        {
            ProductPriceList = new HashSet<ProductPriceList>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
