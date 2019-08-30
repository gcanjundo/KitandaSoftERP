using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerTipo
    {
        public int TipCodigo { get; set; }
        public string TipDescricao { get; set; }
        public string TipSigla { get; set; }
        public string TipStatus { get; set; }
    }
}
