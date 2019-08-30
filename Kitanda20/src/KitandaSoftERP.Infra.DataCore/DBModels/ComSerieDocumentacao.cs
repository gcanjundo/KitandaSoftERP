using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComSerieDocumentacao
    {
        public ComSerieDocumentacao()
        {
            AutoOrdemServico = new HashSet<AutoOrdemServico>();
            ComContratos = new HashSet<ComContratos>();
            ComFaturaCliente = new HashSet<ComFaturaCliente>();
            ComFaturaFornecedor = new HashSet<ComFaturaFornecedor>();
            ComReciboCliente = new HashSet<ComReciboCliente>();
            FinMovimentoCaixa = new HashSet<FinMovimentoCaixa>();
            SatFolhaObra = new HashSet<SatFolhaObra>();
            StockMovimentoDirectos = new HashSet<StockMovimentoDirectos>();
        }

        public int SerCodigo { get; set; }
        public int SerAno { get; set; }
        public int? SerCodigoFilial { get; set; }
        public int SerEntidade { get; set; }
        public string SerDescricao { get; set; }
        public DateTime SerInicio { get; set; }
        public DateTime SerTermino { get; set; }
        public int SerCodigoDocumento { get; set; }
        public int SerNumeracao { get; set; }
        public bool? SerDeleted { get; set; }
        public bool? SerIsActive { get; set; }
        public int SerNroCopias { get; set; }
        public string SerCreatedBy { get; set; }
        public DateTime? SerCreatedDate { get; set; }
        public string SerUpdatedBy { get; set; }
        public DateTime? SerUpdatedDate { get; set; }
        public string SerDeletedBy { get; set; }
        public DateTime? SerDeletedDate { get; set; }

        public virtual ComAnoFaturacao Ser { get; set; }
        public virtual ComDocumento SerCodigoDocumentoNavigation { get; set; }
        public virtual SisEmpresa SerCodigoFilialNavigation { get; set; }
        public virtual ICollection<AutoOrdemServico> AutoOrdemServico { get; set; }
        public virtual ICollection<ComContratos> ComContratos { get; set; }
        public virtual ICollection<ComFaturaCliente> ComFaturaCliente { get; set; }
        public virtual ICollection<ComFaturaFornecedor> ComFaturaFornecedor { get; set; }
        public virtual ICollection<ComReciboCliente> ComReciboCliente { get; set; }
        public virtual ICollection<FinMovimentoCaixa> FinMovimentoCaixa { get; set; }
        public virtual ICollection<SatFolhaObra> SatFolhaObra { get; set; }
        public virtual ICollection<StockMovimentoDirectos> StockMovimentoDirectos { get; set; }
    }
}
