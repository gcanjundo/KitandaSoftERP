using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class ClinicalAttendancePrescriptionMedicine:BaseEntity
    {
        public int? PrescriptionID { get; set; }
        public int MedicineID { get; set; }
        public int? PrescriptionDaysDuracao { get; set; } 
        public decimal MedicineQuantity { get; set; }
        public decimal? MedicineQuantityDelivered { get; set; }

        public virtual ClinicalServices Medicine { get; set; }
        public virtual ClinicalAttendancePrescription Prescription { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
