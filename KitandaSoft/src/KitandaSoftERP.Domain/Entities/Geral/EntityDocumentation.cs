using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class EntityDocumentation: BaseEntity
    {
        public int EntityID { get; set; }
        public int DocumentTypeID { get; set; }
        public string DocumentCode { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ValidateDate { get; set; }
        public string IssueLocation { get; set; } 
        public virtual Entity Entity { get; set; }
        public virtual CitizenDocument DocumentType { get; set; }

        public EntityDocumentation()
        {
            Entity = new Entity();
            DocumentType = new CitizenDocument();
        }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }

    }
}
