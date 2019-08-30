using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhRescisaoContratual
    {
        public int ResCodigo { get; set; }
        public string ResDescricao { get; set; }
        public string ResSigla { get; set; }
        public string ResEstado { get; set; }
        public string ResDetalhes { get; set; }
    }
}
