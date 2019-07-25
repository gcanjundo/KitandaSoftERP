using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class ContactType : BaseEntity
    {
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }

}
