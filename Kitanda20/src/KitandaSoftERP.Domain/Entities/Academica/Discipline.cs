using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq; 

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class Discipline : BaseEntity
    {
        public Discipline()
        {
            CurricularUnitList = new HashSet<CurricularUnit>();
        }
        public virtual ICollection<CurricularUnit> CurricularUnitList { get; set; }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
