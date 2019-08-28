
using KitandaSoftERP.Domain.Entities.Shared; 
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class TeacherPreference:BaseEntity
    {
        public int TeacherID { get; set; }
        public int CurricularUnitID { get; set; } 
        public virtual Teacher Teacher { get; set; }
        public virtual CurricularUnit CurricularUnit { get; set; }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
