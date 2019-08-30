using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComFaturaSuspensa
    {
        public int ComFatSuspCodigo { get; set; }
        public int ComFatSuspReferencia { get; set; }
        public int ComFatSuspCodigoArtigo { get; set; }
        public string ComFatSuspRefArtigo { get; set; }
        public string ComFatSuspArtigo { get; set; }
        public decimal? ComFatSuspQuantidade { get; set; }
        public decimal? ComFatSuspPrecoUnitario { get; set; }
        public decimal? ComFatSuspDesconto { get; set; }
        public decimal? ComFatSuspImposto { get; set; }
        public decimal? ComFatSuspTotallinha { get; set; }
        public int? ComFatSuspImpostoId { get; set; }
        public decimal? ComFatSuspDescontoNumerario { get; set; }
        public int? ComFatSuspUnidadeId { get; set; }
        public string ComFatSuspSiglaUnidade { get; set; }
        public int? ComFatSuspLoteId { get; set; }
        public int? ComFatSuspSerialnumberId { get; set; }
        public int? ComFatSuspDimensaoId { get; set; }
        public string ComFatSupNotes { get; set; }
        public int? ComFatSupWarehouseId { get; set; }
        public string ComFatSupWarehouseName { get; set; }
        public decimal? ComFatSupQuantidadeInicial { get; set; }

        public virtual ComFaturaReferenciaSuspender ComFatSuspReferenciaNavigation { get; set; }
    }
}
