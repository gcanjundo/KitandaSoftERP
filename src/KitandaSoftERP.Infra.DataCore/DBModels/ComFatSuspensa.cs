using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComFatSuspensa
    {
        public int ComFatSuspCodigo { get; set; }
        public string ComFatSuspReferencia { get; set; }
        public string ComFatSuspRefArtigo { get; set; }
        public string ComFatSuspArtigo { get; set; }
        public decimal? ComFatSuspQuantidade { get; set; }
        public decimal? ComFatSuspPrecoUnitario { get; set; }
        public decimal? ComFatSuspDesconto { get; set; }
        public decimal? ComFatSuspImposto { get; set; }
        public decimal? ComFatSuspTotallinha { get; set; }
        public string ComFatSuspUtilizador { get; set; }
        public DateTime ComFatSuspData { get; set; }
    }
}
