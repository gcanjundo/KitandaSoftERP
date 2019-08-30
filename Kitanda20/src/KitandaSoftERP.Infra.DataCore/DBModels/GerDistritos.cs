using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerDistritos
    {
        public GerDistritos()
        {
            InverseDistComuna = new HashSet<GerDistritos>();
        }

        public int DistCodigo { get; set; }
        public int? DistMunicipioId { get; set; }
        public string DistDescricao { get; set; }
        public string DistSigla { get; set; }
        public string DistCreatedBy { get; set; }
        public DateTime? DistCreatedDate { get; set; }
        public string DistUpdatedBy { get; set; }
        public DateTime? DistUpdatedDate { get; set; }
        public int? DistComunaId { get; set; }

        public virtual GerDistritos DistComuna { get; set; }
        public virtual GerMunicipio DistMunicipio { get; set; }
        public virtual ICollection<GerDistritos> InverseDistComuna { get; set; }
    }
}
