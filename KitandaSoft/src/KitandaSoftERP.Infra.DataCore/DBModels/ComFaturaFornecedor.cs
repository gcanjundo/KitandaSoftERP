using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComFaturaFornecedor
    {
        public ComFaturaFornecedor()
        {
            ComFaturaFornecedorItem = new HashSet<ComFaturaFornecedorItem>();
            ComPagamentoFornecedorDocumentos = new HashSet<ComPagamentoFornecedorDocumentos>();
        }

        public int FatCodigo { get; set; }
        public int FatCodigoFilial { get; set; }
        public int? FatCodigoArmazem { get; set; }
        public int FatCodigoDocumento { get; set; }
        public int FatCodigoSerie { get; set; }
        public int FatCodigoFornecedor { get; set; }
        public string FatNomeFornecedor { get; set; }
        public DateTime FatDataEmissao { get; set; }
        public DateTime? FatDataValidade { get; set; }
        public int? FatCodigoMoeda { get; set; }
        public decimal? FatCambio { get; set; }
        public int? FatCondicaoPagamento { get; set; }
        public int? FatCodigoExpedicao { get; set; }
        public decimal? FatDesconto { get; set; }
        public int? FatNumeracao { get; set; }
        public string FatReferencia { get; set; }
        public int? FatStatusDocumento { get; set; }
        public decimal? FatValorBruto { get; set; }
        public decimal? FatTotalDescontos { get; set; }
        public decimal? FatTotalLiquido { get; set; }
        public decimal? FatTotalImpostos { get; set; }
        public decimal? FatValorTotal { get; set; }
        public int? FatStatusPagamento { get; set; }
        public string FatObservacoes { get; set; }
        public int? FatDocumentoOrigem { get; set; }
        public int? FatNumeroDocOrigem { get; set; }
        public decimal? FatValorPago { get; set; }
        public decimal? FatValorSaldo { get; set; }
        public decimal? FatTroco { get; set; }
        public string FatCreatedBy { get; set; }
        public DateTime? FatCreatedDate { get; set; }
        public string FatUpdateBy { get; set; }
        public DateTime? FatUpdatedDate { get; set; }
        public int FatStatus { get; set; }
        public decimal? FatDescontoFornecedor { get; set; }
        public string FatDeletedBy { get; set; }
        public DateTime? FatDeletedDate { get; set; }
        public int? FatStatusComercial { get; set; }
        public string FatCustomerVat { get; set; }
        public DateTime? FatDataCarga { get; set; }
        public string FatMoradaCarga { get; set; }
        public string FatLocalCarga { get; set; }
        public DateTime? FatDataDescarga { get; set; }
        public string FatMoradaDescarga { get; set; }
        public string FatLocalDescarga { get; set; }
        public string FatNotasInternas { get; set; }
        public string FatMotivoAnulacao { get; set; }
        public int? FatParcela { get; set; }
        public int? FatCodigoComprador { get; set; }
        public string FatBarcode { get; set; }
        public DateTime? FatDataEntrega { get; set; }
        public DateTime? FatDataLiquidacao { get; set; }
        public int? FatResponsavelCarga { get; set; }
        public string FatRecepcao { get; set; }
        public string FatResponsavelEntrega { get; set; }
        public decimal? FatValorRetencao { get; set; }
        public decimal? FatValorComissoes { get; set; }
        public int? FatEntityBillId { get; set; }
        public string FatNotasComerciais { get; set; }
        public string FatContactoDestino { get; set; }
        public string FatContactoDestinoAlt { get; set; }
        public string FatMatriculaCarga { get; set; }
        public bool? FatEmailSent { get; set; }
        public string FatEmailSentBy { get; set; }
        public DateTime? FatEmailSentDate { get; set; }
        public bool? FatPaid { get; set; }
        public bool? FatRectified { get; set; }
        public bool? FatAgtSent { get; set; }
        public string FatAgtSentBy { get; set; }
        public DateTime? FatAgtSentDate { get; set; }
        public decimal? FatValorSiva { get; set; }
        public decimal? FatValorCiva { get; set; }
        public string FatSaftStatus { get; set; }
        public string FatSaftSourceBilling { get; set; }
        public bool? FatHashTag { get; set; }
        public decimal? FatCustomerCredit { get; set; }
        public int? FatRectifierDocumentId { get; set; }
        public string FatReferenciaFornecedor { get; set; }

        public virtual GerArmazem FatCodigoArmazemNavigation { get; set; }
        public virtual ComDocumento FatCodigoDocumentoNavigation { get; set; }
        public virtual ComExpedicao FatCodigoExpedicaoNavigation { get; set; }
        public virtual SisEmpresa FatCodigoFilialNavigation { get; set; }
        public virtual GerEntidade FatCodigoFornecedorNavigation { get; set; }
        public virtual FinMoeda FatCodigoMoedaNavigation { get; set; }
        public virtual ComSerieDocumentacao FatCodigoSerieNavigation { get; set; }
        public virtual ComCondicaoPagamento FatCondicaoPagamentoNavigation { get; set; }
        public virtual GerEntidade FatEntityBill { get; set; }
        public virtual ICollection<ComFaturaFornecedorItem> ComFaturaFornecedorItem { get; set; }
        public virtual ICollection<ComPagamentoFornecedorDocumentos> ComPagamentoFornecedorDocumentos { get; set; }
    }
}
