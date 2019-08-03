using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Shared.ValueObject;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Shared
{
    public class EntityEnterprise : Entity
    {
        public string CommercialName { get; set; }
        public string EnterpriseCommericalRegistration { get; set; }
        public int EnterpriseBusinessActivityID { get; set; }
        public virtual BusinessActivity EnterpriseBusinessActivity { get; set; }
        public virtual Branch Branch { get; set; }
        public EntityEnterprise()
        {
            EnterpriseBusinessActivity = new BusinessActivity();
            Branch = new Branch();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
