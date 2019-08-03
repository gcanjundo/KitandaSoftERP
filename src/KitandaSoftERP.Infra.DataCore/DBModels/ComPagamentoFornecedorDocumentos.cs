using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComPagamentoFornecedorDocumentos
    {
        public int PagDocCodigo { get; set; }
        public int PagDocOrdem { get; set; }
        public int PagDocReciboId { get; set; }
        public int PagDocDocumentType { get; set; }
        public int PagDocDocumentoId { get; set; }
        public string PagDocReferencia { get; set; }
        public int? PagDocNumeracao { get; set; }
        public string PagDocValorDocumento { get; set; }
        public decimal? PagDocValorLiquidado { get; set; }
        public decimal? PagDocValorPedente { get; set; }
        public decimal? PagDocDesconto { get; set; }
        public decimal? PagDocJuros { get; set; }
        public bool? PagDocAnulado { get; set; }
        public string PagDocCreatedBy { get; set; }
        public DateTime? PagDocCreatedDate { get; set; }
        public string PagDocUpdatedBy { get; set; }
        public DateTime? PagDocUpdatedDate { get; set; }

        public virtual ComDocumento PagDocDocumentTypeNavigation { get; set; }
        public virtual ComFaturaFornecedor PagDocDocumento { get; set; }
        public virtual ComPagamentoFornecedor PagDocRecibo { get; set; }
    }
}
