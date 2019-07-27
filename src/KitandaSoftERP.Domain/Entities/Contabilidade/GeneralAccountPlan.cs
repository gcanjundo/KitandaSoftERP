using KitandaSoftERP.Domain.Entities.Shared;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Contabilidade
{
    public class GeneralAccountPlan : BaseEntity
    {
        public int GeneralAccountPlanID { get; set; }
        public string GeneralAccountPlanCode { get; set; }
        public GeneralAccountPlan()
        {

        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
