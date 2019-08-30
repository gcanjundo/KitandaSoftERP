using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class ClassRoom : BaseEntity
    {
        
        public int ClassRoomID { get; set; }
        public int CurricularYearID { get; set; }
        public int AcademicYearID { get; set; } 
        public int RoomID { get; set; }
        public string ClassRoomShift { get; set; }
        public bool IsDefault { get; set; } 
        public int MinYear { get; set; }
        public int MaxYear { get; set; }
        public int MinMounth { get; set; }
        public int MaxMounth { get; set; }
        public int MinDays { get; set; }
        public int MaxDays { get; set; }
        public int ColectiveClassRoomID { get; set; }
        public virtual CurricularYear CurricularYear { get; set; } 
        public virtual AcademicYear  AcademicYear { get; set; }
        public virtual Room Room { get; set; }
        public virtual ClassRoom ColectiveClassRoom { get; set; } 
        public virtual ICollection<ClassRoom> ClassesRoomList { get; set; }
        public virtual ICollection<StudentRegistration> StudentRegistrationList { get; set; }
        public virtual ICollection<ClassRoomDirector> ClassesRoomDirectorList { get; set; }
        public virtual ICollection<ClassRoomTeachers> ClassesRoomTeacherList { get; set; }

        public ClassRoom()
        {
            CurricularYear = new CurricularYear();
            AcademicYear = new AcademicYear ();
            Room = new Room();
            ColectiveClassRoom = new ClassRoom();
            ClassesRoomList = new HashSet<ClassRoom>();
            StudentRegistrationList = new HashSet<StudentRegistration>();
            ClassesRoomDirectorList = new HashSet<ClassRoomDirector>();
            ClassesRoomTeacherList = new HashSet<ClassRoomTeachers>();

        }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
