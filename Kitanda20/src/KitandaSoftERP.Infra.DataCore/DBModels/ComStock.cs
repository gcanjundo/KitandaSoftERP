using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComStock
    {
        public int StockCodigoArmazem { get; set; }
        public int StockCodigoArtigo { get; set; }
        public decimal? StockQuantidade { get; set; }
        public decimal? StockContagem { get; set; }
        public decimal? StockQtdMinima { get; set; }
        public decimal? StockQtdMaxima { get; set; }
        public decimal? StockUltimoPrecoCusto { get; set; }
        public DateTime? StockDataUltimaEntrada { get; set; }
        public string StockLocalizacao { get; set; }
        public decimal? StockQtdReposicao { get; set; }
        public decimal? StockQtdEncCliente { get; set; }
        public decimal? StockQtdConsigCliente { get; set; }
        public decimal? StockQtdEncFornecedor { get; set; }
        public decimal? StockQtdConsigFornecedor { get; set; }
        public decimal? StockCustoMedio { get; set; }
        public DateTime? StockDataUltimaSaida { get; set; }
        public DateTime? StockDataUltimaContagem { get; set; }
        public string StockCreatedBy { get; set; }
        public DateTime? StockCreatedDate { get; set; }
        public string StockUpdatedBy { get; set; }
        public DateTime? StockUpdatedDate { get; set; }

        public virtual GerArmazem StockCodigoArmazemNavigation { get; set; }
        public virtual GerArtigo StockCodigoArtigoNavigation { get; set; }
    }
}
