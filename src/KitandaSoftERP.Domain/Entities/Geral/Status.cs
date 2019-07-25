using KitandaSoftERP.Domain.Entities.Shared; 
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class Status : BaseEntity
    {
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }


    }
}
