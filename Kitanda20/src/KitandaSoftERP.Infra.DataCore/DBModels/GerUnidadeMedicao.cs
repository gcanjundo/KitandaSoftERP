using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerUnidadeMedicao
    {
        public GerUnidadeMedicao()
        {
            GerArtigo = new HashSet<GerArtigo>();
        }

        public int UniCodigo { get; set; }
        public string UniDescricao { get; set; }
        public string UniSigla { get; set; }
        public string UniStatus { get; set; }
        public decimal? UniQuantidade { get; set; }

        public virtual ICollection<GerArtigo> GerArtigo { get; set; }
    }
}
