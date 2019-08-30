using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerRaca
    {
        public int RacCodigo { get; set; }
        public string RacDescricao { get; set; }
        public string RacSigla { get; set; }
        public string RacStatus { get; set; }
    }
}
