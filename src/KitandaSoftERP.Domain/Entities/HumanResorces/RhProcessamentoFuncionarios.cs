using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhProcessamentoFuncionarios
    {
        public int ProcFunCodigo { get; set; }
        public int? ProcFunCodigoProcessamento { get; set; }
        public int? ProcFunCodigoFuncionario { get; set; }
        public DateTime? ProcFunData { get; set; }
    }
}
