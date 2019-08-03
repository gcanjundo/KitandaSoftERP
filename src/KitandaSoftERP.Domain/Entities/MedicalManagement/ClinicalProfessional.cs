using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class ClinicalProfessional: EntityPerson
    {
        public ClinicalProfessional()
        {
            ClinicalAttendanceList = new HashSet<ClinicalAttendance>();  
            ClinicalAttendancePresciptionsList = new HashSet<ClinicalAttendancePrescription>();
            ProfessionalScheduleList = new HashSet<ProfessionalSchedule>();
        } 
         
        public string MedicalOrderNumber { get; set; }
        public int MedicalSpeclityID { get; set; } 
        public virtual MedicalSpecialties MedicalSpeciality { get; set; }
        public virtual ICollection<ClinicalAttendance> ClinicalAttendanceList { get; set; } 
        public virtual ICollection<ClinicalAttendancePrescription> ClinicalAttendancePresciptionsList { get; set; }
        public virtual ICollection<ProfessionalSchedule> ProfessionalScheduleList { get; set; }
    }
}
