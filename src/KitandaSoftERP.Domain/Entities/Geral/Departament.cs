using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class Departament: Entity
    { 
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }

     
}
