using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerArmazem
    {
        public GerArmazem()
        {
            ComFaturaCliente = new HashSet<ComFaturaCliente>();
            ComFaturaFornecedor = new HashSet<ComFaturaFornecedor>();
            ComStock = new HashSet<ComStock>();
            ComStockInventario = new HashSet<StockInventory>();
            GerArmazemPermissoes = new HashSet<GerArmazemPermissoes>();
            StockMovimentoDirectosMovCodigoArmazemFromNavigation = new HashSet<StockMovimentoDirectos>();
            StockMovimentoDirectosMovCodigoArmazemNavigation = new HashSet<StockMovimentoDirectos>();
            StockMovimentoDirectosMovCodigoArmazemToNavigation = new HashSet<StockMovimentoDirectos>();
        }

        public int ArmCodigo { get; set; }
        public string ArmDescricao { get; set; }
        public int? ArmCodigoFilial { get; set; }
        public string ArmSigla { get; set; }
        public string ArmStatus { get; set; }
        public string ArmAlertaSm { get; set; }
        public string ArmPermiteNegativo { get; set; }
        public string ArmAlertaNegativo { get; set; }
        public string ArmTipo { get; set; }
        public bool? ArmPos { get; set; }
        public bool? ArmInStatus { get; set; }
        public bool? ArmOutStatus { get; set; }
        public string ArmCreatedBy { get; set; }
        public DateTime? ArmCreatedDate { get; set; }
        public string ArmUpdatedBy { get; set; }
        public DateTime? ArmUpdatedDate { get; set; }
        public string ArmDeletedBy { get; set; }
        public DateTime? ArmDeletedDate { get; set; }

        public virtual ICollection<ComFaturaCliente> ComFaturaCliente { get; set; }
        public virtual ICollection<ComFaturaFornecedor> ComFaturaFornecedor { get; set; }
        public virtual ICollection<ComStock> ComStock { get; set; }
        public virtual ICollection<StockInventory> ComStockInventario { get; set; }
        public virtual ICollection<GerArmazemPermissoes> GerArmazemPermissoes { get; set; }
        public virtual ICollection<StockMovimentoDirectos> StockMovimentoDirectosMovCodigoArmazemFromNavigation { get; set; }
        public virtual ICollection<StockMovimentoDirectos> StockMovimentoDirectosMovCodigoArmazemNavigation { get; set; }
        public virtual ICollection<StockMovimentoDirectos> StockMovimentoDirectosMovCodigoArmazemToNavigation { get; set; }
    }
}
