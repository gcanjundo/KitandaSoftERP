using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class ClinicalAttendanceDiagnosis:BaseEntity
    {
        public int ClinicalAttendanceID { get; set; }
        public int CIDId { get; set; }
        public virtual ClinicalAttendance ClinicalAttendance { get; set; }
        public virtual CIDTable CID { get; set; }
        public ClinicalAttendanceDiagnosis()
        {
            ClinicalAttendance = new ClinicalAttendance();
            CID = new CIDTable();
        }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
