using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class CIDTable: BaseEntity
    {
        public CIDTable()
        {
            DiagnosisList = new HashSet<ClinicalAttendanceDiagnosis>();
        } 

        public virtual ICollection<ClinicalAttendanceDiagnosis> DiagnosisList { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
