using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComReciboClienteDocumentos
    {
        public int RecDocCodigo { get; set; }
        public int RecDocOrdem { get; set; }
        public int RecDocReciboId { get; set; }
        public int RecDocDocumentType { get; set; }
        public int RecDocDocumentoId { get; set; }
        public string RecDocReferencia { get; set; }
        public int? RecDocNumeracao { get; set; }
        public string RecDocValorDocumento { get; set; }
        public decimal? RecDocValorLiquidado { get; set; }
        public decimal? RecDocValorPedente { get; set; }
        public decimal? RecDocDesconto { get; set; }
        public decimal? RecDocJuros { get; set; }
        public bool? RecDocAnulado { get; set; }
        public string RecDocCreatedBy { get; set; }
        public DateTime? RecDocCreatedDate { get; set; }
        public string RecDocUpdatedBy { get; set; }
        public DateTime? RecDocUpdatedDate { get; set; }

        public virtual ComDocumento RecDocDocumentTypeNavigation { get; set; }
        public virtual ComFaturaCliente RecDocDocumento { get; set; }
        public virtual ComReciboCliente RecDocRecibo { get; set; }
    }
}
