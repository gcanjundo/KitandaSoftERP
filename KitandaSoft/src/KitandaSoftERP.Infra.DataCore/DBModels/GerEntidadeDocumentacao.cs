using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerEntidadeDocumentacao
    {
        public int EntDocCodigo { get; set; }
        public int EntDocCodigoEntidade { get; set; }
        public int EntDocCodigoDocumento { get; set; }
        public string EntDocNumero { get; set; }
        public DateTime? EntDocEmissao { get; set; }
        public DateTime? EntDocValidade { get; set; }
        public string EntDocLocalEmissao { get; set; }

        public virtual GerDocumento EntDocCodigoDocumentoNavigation { get; set; }
        public virtual GerEntidade EntDocCodigoEntidadeNavigation { get; set; }
    }
}
