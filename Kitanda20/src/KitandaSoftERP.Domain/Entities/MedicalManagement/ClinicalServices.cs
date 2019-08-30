using KitandaSoftERP.Domain.Entities.Comercial;
using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class ClinicalServices: Product
    {
        public ClinicalServices()
        {
            ClinicalAttendanceProcedureList = new HashSet<ClinicalAttendanceProcedure>();
            MedicalSpecility = new MedicalSpecialties();
            ClinicalAttendancePrescriptionMedicineList = new HashSet<ClinicalAttendancePrescriptionMedicine>();
        }
         
        public int? MedicalSpecilityID { get; set; } 
        public virtual MedicalSpecialties MedicalSpecility { get; set; }
        public virtual ICollection<ClinicalAttendanceProcedure> ClinicalAttendanceProcedureList { get; set; }
        public virtual ICollection<ClinicalAttendancePrescriptionMedicine> ClinicalAttendancePrescriptionMedicineList { get; set; }
    }
}
