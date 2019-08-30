using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerArtigoDimensoes
    {
        public int DimCodigo { get; set; }
        public int? DimCodigoArtigo { get; set; }
        public int? DimCodigoTamanho { get; set; }
        public int? DimCodigoCor { get; set; }
        public string DimReferencia { get; set; }
        public decimal? DimStockActual { get; set; }
        public decimal? DimStockEntrada { get; set; }
        public decimal? DimStockSaida { get; set; }
        public DateTime? DimDataUltimaEntrada { get; set; }
        public DateTime? DimDataValidade { get; set; }
        public DateTime? DimDataLimiteFaturacao { get; set; }
        public decimal? DimCustoPonderado { get; set; }
        public decimal? DimUltimoPrecoCusto { get; set; }
        public string DimRefFornecedor { get; set; }
        public string DimCodigoBarras { get; set; }
        public string DimCreatedBy { get; set; }
        public DateTime? DimCreatedDate { get; set; }
        public string DimUpdatedBy { get; set; }
        public DateTime? DimUpdatedDate { get; set; }
        public string DimDeletedBy { get; set; }
        public DateTime? DimDeletedDate { get; set; }
    }
}
