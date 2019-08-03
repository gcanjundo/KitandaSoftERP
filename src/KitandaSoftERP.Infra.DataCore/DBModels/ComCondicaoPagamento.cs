using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComCondicaoPagamento
    {
        public ComCondicaoPagamento()
        {
            ComFaturaCliente = new HashSet<ComFaturaCliente>();
            ComFaturaFornecedor = new HashSet<ComFaturaFornecedor>();
        }

        public int PagCodigo { get; set; }
        public string PagDescricao { get; set; }
        public int? PagSigla { get; set; }
        public string PagStatus { get; set; }
        public string PagCondicao { get; set; }
        public int? PagVencimento { get; set; }
        public decimal? PagEntradaInicial { get; set; }
        public decimal? PagPrestacoes { get; set; }
        public int? PagPeriodicidade { get; set; }
        public decimal? PagDescontoFinanceiro { get; set; }
        public string PagCreatedBy { get; set; }
        public DateTime? PagCreatedDate { get; set; }
        public string PagUpdatedBy { get; set; }
        public DateTime? PagUpdatedDate { get; set; }
        public string PagDeletedBy { get; set; }
        public DateTime? PagDeletedDate { get; set; }

        public virtual ICollection<ComFaturaCliente> ComFaturaCliente { get; set; }
        public virtual ICollection<ComFaturaFornecedor> ComFaturaFornecedor { get; set; }
    }
}
