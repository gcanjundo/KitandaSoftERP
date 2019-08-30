using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class Teacher : EntityPerson
    {
        public int TeacherID { get; set; } 
        public int PersonID { get; set; }
        public int CandidateID { get; set; }
        public int OrderNumber { get; set; }
        public string RegistrationReference { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string ExternalRegistrationReference { get; set; }  
        public virtual EntityPerson Person { get; set; }
        public virtual ICollection<TeacherPreference> TeacherPrefereences { get; set; }
        public virtual ICollection<ClassRoomTeachers> ClassesRoomTeacher { get; set; }
        public virtual ICollection<ClassRoomDirector> ClassesRoomDirectors { get; set; }
        public override bool IsValid()
        {
            ConfirmaValidacaoEmail();
            return !ErrorList.Any();
        }
    }
}
