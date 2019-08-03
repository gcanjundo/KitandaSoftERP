using KitandaSoftERP.Domain.Entities.Academica;
using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class Qualifications : BaseEntity
    {
        public virtual ICollection<Course> Cousers { get; set; }
        public ICollection<EntityPerson> EntityPersonsList { get; set; }

        public Qualifications()
        {
            EntityPersonsList = new HashSet<EntityPerson>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }


    }
}
