using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class Province:BaseEntity
    {
        
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }

        public override bool IsValid() => !ErrorList.Any();
    }
}
