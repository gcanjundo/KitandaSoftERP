using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComPlanoPagamento
    {
        public int PlanCodigo { get; set; }
        public int? PlanContratoId { get; set; }
        public int? PlanSerieId { get; set; }
        public int? PlanPaymentDays { get; set; }
        public DateTime? PlanInicio { get; set; }
        public DateTime? PlanTermino { get; set; }
        public int? PlanAlertBeforeExpired { get; set; }
        public int? PlanAlertAfterExpired { get; set; }
        public string PlanCreatedBy { get; set; }
        public DateTime? PlanCreatedDate { get; set; }
        public string PlanUpdatedBy { get; set; }
        public DateTime? PlanUpdatedDate { get; set; }
        public string PlanNumeracao { get; set; }

        public virtual ComContratos PlanContrato { get; set; }
    }
}
