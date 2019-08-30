using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerDocumentosRelacionados
    {
        public int DocMainDocumentId { get; set; }
        public int DocRelatedDocumentId { get; set; }
        public int? DocMainDocumentType { get; set; }
        public int? DocRelatedDocumentType { get; set; }
        public string DocCreatedBy { get; set; }
        public DateTime? DocCreatedDate { get; set; }

        public virtual ComFaturaCliente DocMainDocument { get; set; }
        public virtual ComFaturaCliente DocRelatedDocument { get; set; }
    }
}
