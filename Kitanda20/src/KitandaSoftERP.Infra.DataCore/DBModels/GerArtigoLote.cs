using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerArtigoLote
    {
        public int LotCodigo { get; set; }
        public string LotReferencia { get; set; }
        public string LotCodigoBarras { get; set; }
        public int LotCodigoArtigo { get; set; }
        public string LotStatus { get; set; }
        public decimal? LotStockActual { get; set; }
        public decimal? LotStockRecepcao { get; set; }
        public decimal? LotStockEntrada { get; set; }
        public decimal? LotStockSaida { get; set; }
        public DateTime? LotDataUltimaEntrada { get; set; }
        public DateTime? LotDataFabrico { get; set; }
        public DateTime? LotDataValidade { get; set; }
        public DateTime? LotDataLimiteFaturacao { get; set; }
        public decimal? LotCustoPonderado { get; set; }
        public decimal? LotUltimoPrecoCusto { get; set; }
        public int? LotSupplierId { get; set; }
        public int? LotIncomeUnit { get; set; }
        public int? LotStockUnit { get; set; }
        public int? LotOutcomeUnit { get; set; }
        public int? LotSalesUnit { get; set; }
        public int? LotPurchageUnit { get; set; }
        public string LotCreatedBy { get; set; }
        public DateTime? LotCreatedDate { get; set; }
        public string LotUpdatedBy { get; set; }
        public DateTime? LotUpdatedDate { get; set; }
    }
}
