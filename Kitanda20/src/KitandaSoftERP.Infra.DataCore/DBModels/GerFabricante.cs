using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerFabricante
    {
        public int FabCodigo { get; set; }
        public string FabDescricao { get; set; }
        public string FabSigla { get; set; }
        public string FabStatus { get; set; }
    }
}
