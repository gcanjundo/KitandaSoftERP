using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComReciboCliente
    {
        public ComReciboCliente()
        {
            ComReciboClienteDocumentos = new HashSet<ComReciboClienteDocumentos>();
        }

        public int RecCodigo { get; set; }
        public int? RecCodigoFilial { get; set; }
        public int RecCodigoDocumento { get; set; }
        public int? RecCodigoSerie { get; set; }
        public int? RecCodigoEntidade { get; set; }
        public DateTime RecDataEmissao { get; set; }
        public int RecNumeracao { get; set; }
        public string RecReferencia { get; set; }
        public int? RecCodigoMoeda { get; set; }
        public decimal? RecCambio { get; set; }
        public decimal? RecValorTotal { get; set; }
        public decimal? RecValorPago { get; set; }
        public string RecNomeCliente { get; set; }
        public string RecContribuinte { get; set; }
        public string RecObservacoes { get; set; }
        public bool? RecStatus { get; set; }
        public string RecMotivoAnulacao { get; set; }
        public string RecCreatedBy { get; set; }
        public DateTime? RecCreatedDate { get; set; }
        public string RecUpdatedBy { get; set; }
        public DateTime? RecUpdatedDate { get; set; }
        public string RecBarcode { get; set; }
        public int? RecDocFromType { get; set; }
        public int? RecDocFromNumber { get; set; }
        public string RecAbortedBy { get; set; }
        public DateTime? RecAbortedDate { get; set; }
        public string RecFrom { get; set; }
        public decimal? RecDesconto { get; set; }
        public decimal? RecDescontoNumerario { get; set; }
        public int? RecTaxId { get; set; }

        public virtual ComDocumento RecCodigoDocumentoNavigation { get; set; }
        public virtual GerTerceiros RecCodigoEntidadeNavigation { get; set; }
        public virtual SisEmpresa RecCodigoFilialNavigation { get; set; }
        public virtual FinMoeda RecCodigoMoedaNavigation { get; set; }
        public virtual ComSerieDocumentacao RecCodigoSerieNavigation { get; set; }
        public virtual ICollection<ComReciboClienteDocumentos> ComReciboClienteDocumentos { get; set; }
    }
}
