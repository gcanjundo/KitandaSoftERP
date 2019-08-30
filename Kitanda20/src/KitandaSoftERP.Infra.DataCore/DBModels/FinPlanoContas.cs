using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class FinPlanoContas
    {
        public FinPlanoContas()
        {
            FinContasTesouraria = new HashSet<FinContasTesouraria>();
            InversePlanCodigoPaiNavigation = new HashSet<FinPlanoContas>();
        }

        public int PlanCodigo { get; set; }
        public string PlanConta { get; set; }
        public string PlanDescricao { get; set; }
        public int? PlanCodigoPai { get; set; }
        public bool? PlanEstado { get; set; }
        public string PlanClasse { get; set; }
        public string PlanNivel { get; set; }

        public virtual FinPlanoContas PlanCodigoPaiNavigation { get; set; }
        public virtual ICollection<FinContasTesouraria> FinContasTesouraria { get; set; }
        public virtual ICollection<FinPlanoContas> InversePlanCodigoPaiNavigation { get; set; }
    }
}
