using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComCatalogoDocumentoAcao
    {
        public int DocMovCodigo { get; set; }
        public int? DocMovCodigoDocumento { get; set; }
        public string DocMovDescricao { get; set; }
        public string DocMovAccao { get; set; }
        public short? DocStatus { get; set; }
    }
}
