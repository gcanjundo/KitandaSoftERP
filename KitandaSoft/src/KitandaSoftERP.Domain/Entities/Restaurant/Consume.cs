using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Restaurant
{
    public class Consume : BaseEntity
    {
        public int ConsomerCardID { get; set; }
        public int TableID { get; set; }
        public DateTime ConsomerDate { get; set; }
        public virtual ConsomerCard ConsomerCard { get; set; }
        public virtual Table Table { get; set; }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
