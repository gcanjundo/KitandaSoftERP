
using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class UnitClassification:BaseEntity
    {
        public virtual ICollection<CurricularUnit> CurricularUnits { get; set; }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }

    }
}