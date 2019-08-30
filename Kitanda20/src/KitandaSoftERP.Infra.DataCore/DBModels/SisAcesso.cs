using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisAcesso
    {
        public long AceCodigo { get; set; }
        public string AceUtilizador { get; set; }
        public string AceMaquina { get; set; }
        public string AceIp { get; set; }
        public string AceDataLogin { get; set; }
        public string AceHoraLogin { get; set; }
        public string AceDataLogout { get; set; }
        public string AceHoraLogout { get; set; }
        public string AceStatus { get; set; }
    }
}
