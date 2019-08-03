using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class StockMovimentosDirectosArtigos
    {
        public int MovStkArtCodigoMovimento { get; set; }
        public int MovStkArtCodigoArtigo { get; set; }
        public DateTime? MovStkArtDataMovimento { get; set; }
        public decimal? MovStkArtExistencia { get; set; }
        public decimal MovStkArtQuantidade { get; set; }
        public decimal? MovStkArtQtdFinal { get; set; }
        public decimal? MovStkArtPrecoUnitario { get; set; }
        public string MovStkArtTipoMovimento { get; set; }
        public int? MovStkArtCodigoArmazemFrom { get; set; }
        public int? MovStkArtCodigoArmazemTo { get; set; }
        public string MovStkArtCreatedBy { get; set; }
        public DateTime? MovStkArtCreatedDate { get; set; }
        public string MovStkArtUpdatedBy { get; set; }
        public DateTime? MovStkArtUpdatedDate { get; set; }
        public bool? MovStkStatus { get; set; }
        public decimal? MovStkUltimoPrecoCusto { get; set; }
        public decimal? MovStkValorPc { get; set; }
        public decimal? MovStkValorPvp { get; set; }
        public int? MovStkCodigoFilial { get; set; }
        public int? MovStkDocumentType { get; set; }
        public int? MovStkDocumentId { get; set; }
        public int? MovStkLoteId { get; set; }
        public int? MovStkSerialNumberId { get; set; }
        public int? MovStkComposeId { get; set; }
        public int? MovStkSizeId { get; set; }
        public DateTime? MovStkDataContagem { get; set; }
        public int? MovStkContagemId { get; set; }

        public virtual GerArtigo MovStkArtCodigoArtigoNavigation { get; set; }
    }
}
