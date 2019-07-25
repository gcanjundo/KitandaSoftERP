using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class City: BaseEntity
    { 
        public int ProvinceID { get; set; }
        public virtual Province Province { get; set; } 
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
