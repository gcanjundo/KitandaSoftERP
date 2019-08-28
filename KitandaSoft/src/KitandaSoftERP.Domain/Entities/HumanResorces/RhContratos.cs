using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhContratos
    {
        public int ContCodigo { get; set; }
        public string ContDescricao { get; set; }
        public int? ContCategoria { get; set; }
        public string ContDuracao { get; set; }
        public int? ContAvisoPrevio { get; set; }
        public int? ContRenovacoes { get; set; }
    }
}
