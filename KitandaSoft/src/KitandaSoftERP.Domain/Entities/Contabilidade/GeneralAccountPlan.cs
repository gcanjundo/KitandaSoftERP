using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Contabilidade
{
    public class GeneralAccountPlan : BaseEntity
    {
        public int GeneralAccountPlanID { get; set; }
        public string GeneralAccountPlanCode { get; set; }
        public  ICollection<Entity> EntitiesList { get; set; }
        public GeneralAccountPlan()
        {
            EntitiesList = new HashSet<Entity>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
