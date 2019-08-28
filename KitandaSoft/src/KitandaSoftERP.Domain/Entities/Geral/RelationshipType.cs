using KitandaSoftERP.Domain.Entities.Academica;
using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class RelationshipType : BaseEntity
    {
        public ICollection<StudentFamily> MyProperty { get; set; }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }


    }
}
