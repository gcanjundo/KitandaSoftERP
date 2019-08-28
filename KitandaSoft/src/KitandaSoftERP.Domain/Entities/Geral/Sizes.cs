using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public partial class Sizes : BaseEntity
    {
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
     
}
