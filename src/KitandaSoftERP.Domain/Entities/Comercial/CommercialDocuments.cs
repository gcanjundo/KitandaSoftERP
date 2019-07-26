using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Comercial
{

    public class CommercialDocuments : Document
    {
        public ICollection<SerialCommercialDocuments> SerialCommercialDocuments { get; set; }
        public CommercialDocuments()
        {
            SerialCommercialDocuments = new HashSet<SerialCommercialDocuments>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
