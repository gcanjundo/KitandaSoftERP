using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Shared.ValueObject;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Shared
{
    public class EntityEnterprise : Entity
    {   
        public int EnterpriseID { get; set; }   
        public string CommericalRegistration { get; set; }
        public int BusinessActivityID { get; set; }
        public virtual BusinessActivity BusinessActivity { get; set; }
        
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
