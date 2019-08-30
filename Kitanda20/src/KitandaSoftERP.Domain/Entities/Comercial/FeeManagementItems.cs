using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class FeeManagementItems : BaseEntity
    {
        public int FeeManagementItemID { get; set; }
        public int FeeManagementID { get; set; }
        public int ProductID { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountPercentage { get; set; }

        public virtual FeeManagement FeeManagement { get; set; }
        public virtual Product Product { get; set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
