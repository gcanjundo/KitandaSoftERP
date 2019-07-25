using KitandaSoftERP.Domain.Entities.Shared;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class ClassRoomTeachers: BaseEntity
    {
        public ClassRoomTeachers()
        {
            ClassRoom = new ClassRoom();
            Teacher = new Teacher();
            CurricularUnit = new CurricularUnit();
        }

        public int ClassRoomID { get; set; }
        public int TeacherID { get; set; }
        public int CurricularUnitID { get; set; } 
        public virtual ClassRoom ClassRoom { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual CurricularUnit CurricularUnit { get; set; }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
