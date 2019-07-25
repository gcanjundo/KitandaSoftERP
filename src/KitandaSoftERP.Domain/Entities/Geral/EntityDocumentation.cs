using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class EntityDocumentation: BaseEntity
    { 
        public int EntityID { get; set; }
        public int DocumentID { get; set; }
        public string DocumentIdentification { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ValidateDate { get; set; }
        public string IssueLocation { get; set; } 
        public virtual Entity Entity { get; set; }
        public virtual CitzenDocument Document { get; set; }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }

    }
}
