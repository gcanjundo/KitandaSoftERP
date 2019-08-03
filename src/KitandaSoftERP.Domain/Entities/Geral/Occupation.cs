using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class Occupation : BaseEntity
    {
        public ICollection<EntityPerson> EntityPersonsList { get; set; }

        public Occupation()
        {
            EntityPersonsList = new HashSet<EntityPerson>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }


    }
}
