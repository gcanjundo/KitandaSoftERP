using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class Patient:EntityPerson
    {
        public Patient()
        {
            ClinicalAttendanceList = new HashSet<ClinicalAttendance>();
            CliConsultaReceita = new HashSet<ClinicalAttendancePrescription>();
            CliPacienteConvenio = new HashSet<PatientInsurancePolicy>();
            Customer = new Customer();
        }
         
        public DateTime PatientRegistrationDate { get; set; }
        public int? PhisicalDeficiencyID { get; set; }
        public int? CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<ClinicalAttendance> ClinicalAttendanceList { get; set; }
        public virtual ICollection<ClinicalAttendancePrescription> CliConsultaReceita { get; set; }
        public virtual ICollection<PatientInsurancePolicy> CliPacienteConvenio { get; set; }
    }
}
