using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{


    public class ClassRoomDirector:BaseEntity
    {
        public ClassRoomDirector()
        {
            ClassRoom = new ClassRoom();
            Teacher = new Teacher();
        }

        public int ClassRoomID { get; set; }
        public int TeacherID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime TerminateDate { get; set; }  
        public virtual ClassRoom ClassRoom { get; set; }
        public virtual Teacher Teacher { get; set; }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
