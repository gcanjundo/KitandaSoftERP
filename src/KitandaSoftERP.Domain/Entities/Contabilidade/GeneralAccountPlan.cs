using KitandaSoftERP.Domain.Entities.Shared;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Contabilidade
{
    public class GeneralAccountPlan : BaseEntity
    { 
        public GeneralAccountPlan()
        {

        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
