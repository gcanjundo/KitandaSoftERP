using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class CurricularYear:BaseEntity
    {

        public int CurricularYearOrder { get; set; }
        public int CurricularYearID { get; set; }
        public int CourseID { get; set; }
        public string Designacao { get; set; }
        public string CurricularYearType { get; set; }
        public int Age { get; set; }
        public string AllowedDeadLineDate { get; set; }
        public virtual Course Course { get; set; }

        public virtual ICollection<CurricularUnit> CurricularUnitList { get; set; }
        public virtual ICollection<ClassRoom> ClassesRoomList { get; set; }
        public CurricularYear()
        {
            Course = new Course();
            CurricularUnitList = new HashSet<CurricularUnit>();
            ClassesRoomList = new HashSet<ClassRoom>(); 
        }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
