using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class CliProcessoClinico
    {
        public int ProcCodigoPaciente { get; set; }
        public DateTime ProcDataAbertura { get; set; }
        public DateTime? ProcDataEncerramento { get; set; }
        public int ProcCodigoStatus { get; set; }
    }
}
