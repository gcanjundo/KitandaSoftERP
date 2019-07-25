using KitandaSoftERP.Domain.Entities.Shared;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class TablePrice : BaseEntity
    {
        
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
