using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class Department: Entity
    { 
        public override bool IsValid()
        {
            if (string.IsNullOrEmpty(Designation))
                ErrorList.Add("A Designação do Departamento é obrigatória");
             
            return !ErrorList.Any();
        }
    }

     
}
