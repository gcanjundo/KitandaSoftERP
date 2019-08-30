using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class ClinicalAttendance: BaseEntity
    {        
        public int PatientID { get; set; } 
        public DateTime AttendanceDate { get; set; }
        public DateTime StartMedicalAttendance { get; set; }
        public DateTime EndMedicalAttendance { get; set; }  
        public string AttendanceClassification { get; set; }
        public int ClinicalProfessionalID { get; set; } 
        public int AttendanceDepartmentID { get; set; } 
        public string ManchesterClassification { get; set; }
        public int ClinicalAttendanceStatusID { get; set; }
        public int? ClinicalOutcomeID { get; set; }
        public virtual ClinicalProfessional ClinicalProfessional { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ClinicalDepartment ClinicalDepartment { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual ClinicalOutcome ClinicalOutcome { get; set; }
        public virtual ClinicalAttendanceInsurance ClinicalAttendanceInsurance { get; set; }
        public virtual ClinicalAttendanceStatus ClinicalAttendanceStatus { get; set; }
        public virtual ICollection<ClinicalAttendanceProcedure> ClinicalAttendanceProcedureList { get; set; } 
        public virtual ICollection<ClincalAttendanceScreening> ClincalAttendanceScreening { get; set; }

        public ClinicalAttendance()
        {
            Patient = new Patient();
            ClinicalProfessional = new ClinicalProfessional();
            Branch = new Branch();
            ClinicalAttendanceStatus = new ClinicalAttendanceStatus();
            ClincalAttendanceScreening = new HashSet<ClincalAttendanceScreening>();
            ClinicalAttendanceProcedureList = new HashSet<ClinicalAttendanceProcedure>();
        }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
