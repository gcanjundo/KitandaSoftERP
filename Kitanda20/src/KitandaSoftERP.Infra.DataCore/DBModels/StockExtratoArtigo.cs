using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class StockExtratoArtigo
    {
        public int ExtCodigo { get; set; }
        public DateTime? ExtData { get; set; }
        public int? ExtCodigoDocumento { get; set; }
        public int? ExtSerie { get; set; }
        public string ExtNroDoc { get; set; }
        public decimal? ExtPrecoUnitario { get; set; }
        public decimal? ExtPrecoMedio { get; set; }
        public decimal? ExtQtdOriginal { get; set; }
        public decimal? ExtQtdMovimentada { get; set; }
        public decimal? ExtExistencia { get; set; }
    }
}
