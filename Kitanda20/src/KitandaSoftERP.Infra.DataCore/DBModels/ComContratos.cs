using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComContratos
    {
        public ComContratos()
        {
            ComPlanoPagamento = new HashSet<ComPlanoPagamento>();
        }

        public int ContCodigo { get; set; }
        public int? ContEntidadeId { get; set; }
        public int? ContSerieId { get; set; }
        public string ContReferencia { get; set; }
        public int? ContNumeracao { get; set; }
        public string ContVersao { get; set; }
        public DateTime? ContData { get; set; }
        public DateTime? ContValidadeDe { get; set; }
        public DateTime? ContValidadeAte { get; set; }
        public int? ContEstado { get; set; }
        public decimal? ContValor { get; set; }
        public bool? ContRenovavel { get; set; }
        public int? ContMoedaId { get; set; }
        public decimal? ContCambio { get; set; }
        public int? ContPaymentMethodId { get; set; }
        public int? ContPaymentTermsId { get; set; }
        public decimal? ContDescontoComercial { get; set; }
        public double? ContDescontoFinaceiro { get; set; }
        public string ContCreatedBy { get; set; }
        public DateTime? ContCreatedDate { get; set; }
        public string ContUpdatedBy { get; set; }
        public DateTime? ContUpdatedDate { get; set; }

        public virtual GerEntidade ContEntidade { get; set; }
        public virtual ComSerieDocumentacao ContSerie { get; set; }
        public virtual ICollection<ComPlanoPagamento> ComPlanoPagamento { get; set; }
    }
}
