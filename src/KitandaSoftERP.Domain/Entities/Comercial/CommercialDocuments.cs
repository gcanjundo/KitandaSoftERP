using KitandaSoftERP.Domain.Entities.Shared;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Comercial
{

    public class CommercialDocuments : BaseEntity
    {
        public CommercialDocuments()
        {

        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
