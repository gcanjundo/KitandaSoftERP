using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class ClinicalAttendancePrescription:BaseEntity
    {
        public ClinicalAttendancePrescription()
        {
            MedicineList = new HashSet<ClinicalAttendancePrescriptionMedicine>();
        }

         
        public DateTime PrescriptionData { get; set; }
        public int? PrescriptionSerieID { get; set; }
        public int? Reference { get; set; }
        public int? Numeracao { get; set; }
        public int? ClinicalAttendanceId { get; set; }
        public int? ProfissonalId { get; set; }
        public int? PacientId { get; set; }
        public string BarCode { get; set; }

        public virtual ClinicalAttendance ClinicalAttendance { get; set; }
        public virtual Patient Pacient { get; set; }
        public virtual ClinicalProfessional Profissonal { get; set; }
        public virtual ICollection<ClinicalAttendancePrescriptionMedicine> MedicineList { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
