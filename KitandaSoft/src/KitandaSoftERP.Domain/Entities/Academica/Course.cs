using KitandaSoftERP.Domain.Entities.Geral;

using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class Course:BaseEntity
    {

        public int ParentCourseID { get; set; }  
        public int GraduationID { get; set; } 
        public int CoordenationID { get; set; }
        public int Duration { get; set; }
        public int CourseType { get; set; }
        public int DurationBegin { get; set; }
        public int DurateTermine { get; set; } 
        public int QualificationID { get; set; }
        public string SchoolMap  { get; set; }   
        public virtual Graduation Graduation { get; set; }
        public virtual Qualifications Qualification { get; set; }
        public virtual Coordenation Coordination { get; set; } 
        public virtual ICollection<CurricularYear> CurricularYearsList { get; set; } 

        public Course()
        {
            Graduation = new Graduation();
            Qualification = new Qualifications();
            Coordination = new Coordenation();
            CurricularYearsList = new HashSet<CurricularYear>();
        }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
