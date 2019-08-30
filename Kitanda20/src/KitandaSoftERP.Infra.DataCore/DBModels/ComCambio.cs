using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComCambio
    {
        public int CamCodigoMoeda { get; set; }
        public decimal? CamValor { get; set; }
        public DateTime? CamData { get; set; }
    }
}
