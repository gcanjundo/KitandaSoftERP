using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class HealtInsurancePlanCoverage
    {
        public int CobCodigoConvenio { get; set; }
        public int CobCodigoServico { get; set; }
        public decimal? CobValorParceiro { get; set; }
        public decimal? CobValorUtente { get; set; }
        public bool? CobStatus { get; set; }
        public string CobCreatedBy { get; set; }
        public DateTime? CobCreatedDate { get; set; }
        public string CobUpdatedBy { get; set; }
        public DateTime? CobUpdatedDate { get; set; }

        public virtual HealtInsurancePlan CobCodigoConvenioNavigation { get; set; }
        public virtual GerArtigo CobCodigoServicoNavigation { get; set; }
    }
}
