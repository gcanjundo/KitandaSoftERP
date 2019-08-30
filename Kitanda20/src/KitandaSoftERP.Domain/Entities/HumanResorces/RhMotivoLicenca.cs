using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhMotivoLicenca
    {
        public int LicCodigo { get; set; }
        public string LicDescricao { get; set; }
        public int? LicDiasRemunerar { get; set; }
        public string LicDescontoDecimoTerceiro { get; set; }
        public string LicDescontoDiasFerias { get; set; }
    }
}
