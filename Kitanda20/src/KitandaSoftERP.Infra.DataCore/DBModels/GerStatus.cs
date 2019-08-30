using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerStatus
    {
        public int StaCodigo { get; set; }
        public string StaDescricao { get; set; }
        public string StaSigla { get; set; }
        public string StaStatus { get; set; }
        public bool? StaClosed { get; set; }
        public bool? StaAborted { get; set; }

        public virtual CliStatus CliStatus { get; set; }
    }
}
