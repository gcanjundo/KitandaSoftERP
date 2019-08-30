using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhEscaloesIrt
    {
        public int IrtCodigo { get; set; }
        public decimal? IrtSalarioDe { get; set; }
        public decimal? IrtSalarioAte { get; set; }
        public decimal? IrtValorMinimo { get; set; }
        public decimal? IrtPercentualDesconto { get; set; }
        public decimal? IrtExcesso { get; set; }
        public string IrtDescricaoEscalao { get; set; }
        public string IrtCreatedBy { get; set; }
        public DateTime? IrtCreatedDate { get; set; }
        public string IrtUpdatedBy { get; set; }
        public DateTime? IrtUpdatedDate { get; set; }
    }
}
