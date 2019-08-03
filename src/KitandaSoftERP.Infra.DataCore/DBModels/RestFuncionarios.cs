using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class RestFuncionarios
    {
        public RestFuncionarios()
        {
            AutoOrdemServicoCheckinTechnician = new HashSet<AutoOrdemServico>();
            AutoOrdemServicoChecklist = new HashSet<AutoOrdemServicoChecklist>();
            AutoOrdemServicoCheckoutTechnician = new HashSet<AutoOrdemServico>();
            AutoOrdemServicoDetails = new HashSet<AutoOrdemServicoDetails>();
            AutoOrdemServicoNotas = new HashSet<AutoOrdemServicoNotas>();
            AutoOrdemServicoOcorrencias = new HashSet<AutoOrdemServicoOcorrencias>();
            AutoOrdemServicoTechnician = new HashSet<AutoOrdemServico>();
            ComStockInventario = new HashSet<StockInventory>();
            InverseGarGroup = new HashSet<RestFuncionarios>();
            SatFolhaObra = new HashSet<SatFolhaObra>();
        }

        public int GarCodigo { get; set; }
        public int? GarCodigoEntidade { get; set; }
        public string GarUtilizador { get; set; }
        public string GarStatus { get; set; }
        public int? GarFilial { get; set; }
        public int? GarComissao { get; set; }
        public decimal? GarValorComissao { get; set; }
        public decimal? GarComissaoVenda { get; set; }
        public decimal? GarComissaoLiquidacao { get; set; }
        public int? GarGroupId { get; set; }
        public string GarGroupDesignation { get; set; }
        public string GarTipo { get; set; }
        public string GarCreatedBy { get; set; }
        public DateTime? GarCreatedDate { get; set; }
        public string GarUpdatedBy { get; set; }
        public DateTime? GarUpdatedDate { get; set; }

        public virtual GerEntidade GarCodigoEntidadeNavigation { get; set; }
        public virtual RestComissaoVenda GarComissaoNavigation { get; set; }
        public virtual SisEmpresa GarFilialNavigation { get; set; }
        public virtual RestFuncionarios GarGroup { get; set; }
        public virtual ICollection<AutoOrdemServico> AutoOrdemServicoCheckinTechnician { get; set; }
        public virtual ICollection<AutoOrdemServicoChecklist> AutoOrdemServicoChecklist { get; set; }
        public virtual ICollection<AutoOrdemServico> AutoOrdemServicoCheckoutTechnician { get; set; }
        public virtual ICollection<AutoOrdemServicoDetails> AutoOrdemServicoDetails { get; set; }
        public virtual ICollection<AutoOrdemServicoNotas> AutoOrdemServicoNotas { get; set; }
        public virtual ICollection<AutoOrdemServicoOcorrencias> AutoOrdemServicoOcorrencias { get; set; }
        public virtual ICollection<AutoOrdemServico> AutoOrdemServicoTechnician { get; set; }
        public virtual ICollection<StockInventory> ComStockInventario { get; set; }
        public virtual ICollection<RestFuncionarios> InverseGarGroup { get; set; }
        public virtual ICollection<SatFolhaObra> SatFolhaObra { get; set; }
    }
}
