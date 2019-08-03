using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhTipoProcessamento
    {
        public int TipProcCodigo { get; set; }
        public string TipProcDescricao { get; set; }
        public string TipProcSigla { get; set; }
        public string TipProcStatus { get; set; }
    }
}
