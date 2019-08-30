using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class Promotions
    {
        public Promotions()
        {
            ComPromocoesArtigos = new HashSet<PromotionsProducts>();
        }

        public int PromCodigo { get; set; }
        public string PromDescricao { get; set; }
        public DateTime? PromInicio { get; set; }
        public DateTime? PromTermino { get; set; }
        public string PromRecorrencia { get; set; }
        public string PromTipo { get; set; }
        public string PromAplicacao { get; set; }
        public decimal? PromQuantidade { get; set; }
        public decimal? PromReducaoPrecoUnitario { get; set; }
        public decimal? PromPrecoUnitarioFixo { get; set; }
        public decimal? PromDescontoFixo { get; set; }
        public string PromUnidadeReducao { get; set; }
        public string PromUnidadePrecoFixo { get; set; }
        public string PromUnidadeDescontoFixo { get; set; }
        public string PromStatus { get; set; }
        public TimeSpan? PromHoraInicio { get; set; }
        public TimeSpan? PromHoraTermino { get; set; }
        public string PromCreatedBy { get; set; }
        public DateTime? PromCreatedDate { get; set; }
        public string PromUpdatedBy { get; set; }
        public DateTime? PromUpdatedDate { get; set; }

        public virtual ICollection<PromotionsProducts> ComPromocoesArtigos { get; set; }
    }
}
