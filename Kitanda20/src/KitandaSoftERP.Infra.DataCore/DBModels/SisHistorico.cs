using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisHistorico
    {
        public long HistCodigo { get; set; }
        public string HistAccao { get; set; }
        public int HistFormulario { get; set; }
        public string HistCodigoRegisto { get; set; }
        public string HistDescricao { get; set; }
        public string HistUtilizador { get; set; }
        public string HistDataAlteracao { get; set; }
        public string HistHora { get; set; }
    }
}
