using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class StockMovimentoDirectos
    {
        public StockMovimentoDirectos()
        {
            InverseMovTransferencia = new HashSet<StockMovimentoDirectos>();
        }

        public int MovCodigo { get; set; }
        public int? MovCodigoDocumento { get; set; }
        public string MovReferencia { get; set; }
        public int MovNumeracao { get; set; }
        public DateTime? MovDataStock { get; set; }
        public DateTime? MovDataLancamento { get; set; }
        public int MovCodigoArmazemFrom { get; set; }
        public int? MovCodigoArmazemTo { get; set; }
        public string MovUserUpdate { get; set; }
        public string MovUserCreate { get; set; }
        public DateTime? MovUpdateDate { get; set; }
        public int? MovFuncionario { get; set; }
        public int? MovDocumentId { get; set; }
        public int? MovEntityId { get; set; }
        public int? MovCodigoArmazem { get; set; }
        public int? MovTransferenciaId { get; set; }
        public int? MovSerieId { get; set; }
        public int? MovDocumentFrom { get; set; }
        public string MovObservacoes { get; set; }
        public int? MovJustificativa { get; set; }
        public bool? MovDeleted { get; set; }
        public string MovDeletedBy { get; set; }
        public DateTime? MovDeletedDate { get; set; }
        public string MovDeleteReason { get; set; }
        public int? MovPurchageInvoiceId { get; set; }

        public virtual GerArmazem MovCodigoArmazemFromNavigation { get; set; }
        public virtual GerArmazem MovCodigoArmazemNavigation { get; set; }
        public virtual GerArmazem MovCodigoArmazemToNavigation { get; set; }
        public virtual ComDocumento MovCodigoDocumentoNavigation { get; set; }
        public virtual ComDocumento MovDocumentFromNavigation { get; set; }
        public virtual ComSerieDocumentacao MovSerie { get; set; }
        public virtual StockMovimentoDirectos MovTransferencia { get; set; }
        public virtual ICollection<StockMovimentoDirectos> InverseMovTransferencia { get; set; }
    }
}
