using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisLogs
    {
        public int LogCodigo { get; set; }
        public string LogUtilizador { get; set; }
        public string LogFormulario { get; set; }
        public string LogAccao { get; set; }
        public string LogIp { get; set; }
        public string LogAlteracao { get; set; }
        public DateTime LogData { get; set; }
    }
}
