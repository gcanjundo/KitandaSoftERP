using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerArtigoComposicao
    {
        public int CompCodigoArtigo { get; set; }
        public int CompCodigoComponente { get; set; }
        public decimal? CompQuantidade { get; set; }
        public decimal? CompPrecoUnitario { get; set; }
        public decimal? CompValor { get; set; }

        public virtual GerArtigo CompCodigoArtigoNavigation { get; set; }
        public virtual GerArtigo CompCodigoComponenteNavigation { get; set; }
    }
}
