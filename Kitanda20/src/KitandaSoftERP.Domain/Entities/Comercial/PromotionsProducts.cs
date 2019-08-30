using KitandaSoftERP.Domain.Entities.Comercial;
using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class PromotionsProducts
    {
        public int PromoCodigo { get; set; }
        public int PromoCodigoPromocao { get; set; }
        public int PromoCodigoArtigo { get; set; }
        public decimal? PromoValor { get; set; }
        public decimal? PromoUnidade { get; set; }
        public string PromoCreatedBy { get; set; }
        public DateTime? PromoCreatedDate { get; set; }
        public string PromoUpdatedBy { get; set; }
        public DateTime? PromoUpdatedDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual Promotions Promotions { get; set; }
    }
}
