using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComCobrancaDocumentos
    {
        public int TaskId { get; set; }
        public int TaskDocId { get; set; }

        public virtual Tasks Task { get; set; }
        public virtual ComFaturaCliente TaskDoc { get; set; }
    }
}
