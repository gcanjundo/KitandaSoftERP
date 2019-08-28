using KitandaSoftERP.Domain.Entities.Academica;
using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Seguranca
{
    public abstract class Document : BaseEntity
    {
        public int DocumentID { get; set; }
        public string Link { get; set; }
        public string HtmlTemplate { get; set; }
        public virtual Branch Branch { get; set; } 
        public Document()
        {
            Branch = new Branch();  
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
