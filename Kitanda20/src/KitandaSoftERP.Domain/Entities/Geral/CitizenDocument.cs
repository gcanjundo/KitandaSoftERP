using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class CitizenDocument: BaseEntity
    { 
        public virtual ICollection<EntityDocumentation> EntityDocumenationList { get; set; }
        public virtual ICollection<Entity> EntityCitizenDocumentList { get; set; }
        public CitizenDocument()
        {
            EntityDocumenationList = new HashSet<EntityDocumentation>();
            EntityCitizenDocumentList = new HashSet<Entity>();
        }
        public override bool IsValid()
        {
            if (string.IsNullOrEmpty(Designation))
                ErrorList.Add("A Designação do Documento é obrigatória");

            return !ErrorList.Any();
        }
    }
}
