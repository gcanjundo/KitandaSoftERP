using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class BloodGroup : BaseEntity
    {
        public ICollection<EntityPerson> EntityPersonsList { get; set; }

        public BloodGroup()
        {
            EntityPersonsList = new HashSet<EntityPerson>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
