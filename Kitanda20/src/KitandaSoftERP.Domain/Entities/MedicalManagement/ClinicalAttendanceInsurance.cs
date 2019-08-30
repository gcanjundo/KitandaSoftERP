using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class ClinicalAttendanceInsurance
    {
        public int ClinicalAttendanceID { get; set; }
        public int InsurancePolicyID { get; set; }

        public virtual ClinicalAttendance ClinicalAttendance { get; set; }
        public virtual PatientInsurancePolicy PatientInsurancePolicy { get; set; }

        public ClinicalAttendanceInsurance()
        {
            ClinicalAttendance = new ClinicalAttendance();
            PatientInsurancePolicy = new PatientInsurancePolicy();
        }
    }
}
