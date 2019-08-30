using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisConfiguracao
    {
        public int SisCodigoFilial { get; set; }
        public int? SisCodigoIdioma { get; set; }
        public int SisPaisPadrao { get; set; }
        public int SisMoedaPadrao { get; set; }
        public string SisEnderecoRecibo { get; set; }
        public int? SisWarehouseDefault { get; set; }
        public int? SisDefaultPaymentMethod { get; set; }
        public string SisStockLoteMode { get; set; }
        public bool? SisStockLevelNotification { get; set; }
        public bool? SisStockExpireDateNotification { get; set; }
        public int? SisStockStartAlertExpire { get; set; }
        public bool? SisStockAllowSalesValidLotes { get; set; }
        public string SisRestModalidade { get; set; }
        public int? SisStockIncomeSerieId { get; set; }
        public int? SisStockOutcomeSerieId { get; set; }
        public bool? SisChangePvpOnpurchage { get; set; }
    }
}
