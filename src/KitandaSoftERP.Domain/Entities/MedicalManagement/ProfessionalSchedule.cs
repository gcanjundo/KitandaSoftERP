using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class ProfessionalSchedule
    {
        public int EscDiaSemana { get; set; }
        public int EscCodigoMedico { get; set; }
        public DateTime EscHoraInicio { get; set; }
        public DateTime EscHoraTermino { get; set; }
        public int EscCodigo { get; set; }

        public virtual ClinicalProfessional EscCodigoMedicoNavigation { get; set; }
    }
}
