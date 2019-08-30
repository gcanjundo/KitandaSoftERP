using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhProcessamento
    {
        public int ProcCodigo { get; set; }
        public int? ProcCodigoGrupo { get; set; }
        public int? ProcCodigoProcessamento { get; set; }
        public DateTime? ProcData { get; set; }
        public int? ProcCodigoPeriodo { get; set; }
    }
}
