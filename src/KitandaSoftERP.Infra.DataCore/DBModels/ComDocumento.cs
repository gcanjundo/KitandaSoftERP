using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComDocumento
    {
        public ComDocumento()
        {
            AutoMarcacao = new HashSet<AutoMarcacao>();
            AutoOrdemServico = new HashSet<AutoOrdemServico>();
            ComDocumentoConversaoDocConvert = new HashSet<ComDocumentoConversao>();
            ComDocumentoConversaoDocOriginal = new HashSet<ComDocumentoConversao>();
            ComFaturaCliente = new HashSet<ComFaturaCliente>();
            ComFaturaFornecedor = new HashSet<ComFaturaFornecedor>();
            ComPagamentoFornecedorDocumentos = new HashSet<ComPagamentoFornecedorDocumentos>();
            ComReciboCliente = new HashSet<ComReciboCliente>();
            ComReciboClienteDocumentos = new HashSet<ComReciboClienteDocumentos>();
            ComSerieDocumentacao = new HashSet<ComSerieDocumentacao>();
            InverseDocCodigoParentNavigation = new HashSet<ComDocumento>();
            SatFolhaObra = new HashSet<SatFolhaObra>();
            StockMovimentoDirectosMovCodigoDocumentoNavigation = new HashSet<StockMovimentoDirectos>();
            StockMovimentoDirectosMovDocumentFromNavigation = new HashSet<StockMovimentoDirectos>();
        }

        public int DocCodigo { get; set; }
        public string DocDescricao { get; set; }
        public string DocSigla { get; set; }
        public string DocTipo { get; set; }
        public string DocStock { get; set; }
        public string DocCc { get; set; }
        public string DocCaixa { get; set; }
        public string DocFormato { get; set; }
        public bool DocEstado { get; set; }
        public string DocCategoria { get; set; }
        public int? DocCodigoParent { get; set; }
        public string DocLink { get; set; }
        public string DocTemplate { get; set; }
        public string DocCreatedBy { get; set; }
        public DateTime? DocCreatedDate { get; set; }
        public string DocUpdatedBy { get; set; }
        public DateTime? DocUpdatedDate { get; set; }
        public string DocDeletedBy { get; set; }
        public DateTime? DocDeletedDate { get; set; }
        public bool? DocDeleted { get; set; }

        public virtual ComDocumento DocCodigoParentNavigation { get; set; }
        public virtual SisDocumentsFormate DocFormatoNavigation { get; set; }
        public virtual ICollection<AutoMarcacao> AutoMarcacao { get; set; }
        public virtual ICollection<AutoOrdemServico> AutoOrdemServico { get; set; }
        public virtual ICollection<ComDocumentoConversao> ComDocumentoConversaoDocConvert { get; set; }
        public virtual ICollection<ComDocumentoConversao> ComDocumentoConversaoDocOriginal { get; set; }
        public virtual ICollection<ComFaturaCliente> ComFaturaCliente { get; set; }
        public virtual ICollection<ComFaturaFornecedor> ComFaturaFornecedor { get; set; }
        public virtual ICollection<ComPagamentoFornecedorDocumentos> ComPagamentoFornecedorDocumentos { get; set; }
        public virtual ICollection<ComReciboCliente> ComReciboCliente { get; set; }
        public virtual ICollection<ComReciboClienteDocumentos> ComReciboClienteDocumentos { get; set; }
        public virtual ICollection<ComSerieDocumentacao> ComSerieDocumentacao { get; set; }
        public virtual ICollection<ComDocumento> InverseDocCodigoParentNavigation { get; set; }
        public virtual ICollection<SatFolhaObra> SatFolhaObra { get; set; }
        public virtual ICollection<StockMovimentoDirectos> StockMovimentoDirectosMovCodigoDocumentoNavigation { get; set; }
        public virtual ICollection<StockMovimentoDirectos> StockMovimentoDirectosMovDocumentFromNavigation { get; set; }
    }
}
