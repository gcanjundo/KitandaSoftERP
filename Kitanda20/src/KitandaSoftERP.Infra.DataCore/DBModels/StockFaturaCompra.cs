using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class StockFaturaCompra
    {
        public int FatCodigo { get; set; }
        public string FatFaturaFornecedor { get; set; }
        public string FatTipo { get; set; }
        public DateTime? FatDataEmissao { get; set; }
        public int? FatCodigoMoeda { get; set; }
        public decimal? FatCambio { get; set; }
        public decimal? FatSeguro { get; set; }
        public decimal? FatValorFatura { get; set; }
        public decimal? FatValorFrete { get; set; }
        public decimal? FatPercentDesconto { get; set; }
        public decimal? FatValorProdutos { get; set; }
        public decimal? FatQuantidadeProdutos { get; set; }
        public decimal? FatValorServico { get; set; }
        public decimal? FatValorImpostos { get; set; }
        public decimal? FatValorDespesasAdic { get; set; }

        public virtual StockEntrada FatCodigoNavigation { get; set; }
    }
}
