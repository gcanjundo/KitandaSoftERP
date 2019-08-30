using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Restaurant
{
    public class ConsumerItems : BaseEntity
    {
        public int ConsomeID { get; set; }
        public int ProductID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal PriorStock { get; set; }
        
        public override bool IsValid()
        {
            return ErrorList.Any();
        }
    }
}
