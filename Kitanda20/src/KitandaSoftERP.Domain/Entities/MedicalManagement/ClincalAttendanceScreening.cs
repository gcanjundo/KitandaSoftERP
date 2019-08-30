using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class ClincalAttendanceScreening:BaseEntity
    {
         
        public int ClinicalAttendanceID { get; set; }
        public int ClinicalProfessionalID { get; set; }
        public string Pulso { get; set; }
        public string Tensao { get; set; }
        public string FrequenciaRespiratoria { get; set; }
        public string SaturacaoOxigenio { get; set; }
        public string Temperatura { get; set; }
        public decimal? Peso { get; set; }
        public decimal? Altura { get; set; }
        public DateTime? Data { get; set; }
        public string Queixa { get; set; } 

        public virtual ClinicalAttendance ClinicalAttendance { get; set; }
        public virtual ClinicalProfessional ClinicalProfessional { get; set; }

        public ClincalAttendanceScreening()
        {
            ClinicalAttendance = new ClinicalAttendance();
            ClinicalProfessional = new ClinicalProfessional();
        }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
