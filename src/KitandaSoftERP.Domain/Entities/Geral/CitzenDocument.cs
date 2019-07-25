using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class CitzenDocument: BaseEntity
    {
        public virtual ICollection<EntityDocumentation> EntityDocumenation { get; set; }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
