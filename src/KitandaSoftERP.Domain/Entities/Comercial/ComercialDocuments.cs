using KitandaSoftERP.Domain.Entities.Shared;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Comercial
{

    public class ComercialDocuments : BaseEntity
    {
        public ComercialDocuments()
        {

        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
