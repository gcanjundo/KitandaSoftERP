using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComSeguradoras
    {
        public int SegCodigo { get; set; }
        public int SegTerceiroId { get; set; }
        public string SegSegmento { get; set; }

        public virtual GerTerceiros SegTerceiro { get; set; }
    }
}
