using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Seguranca
{
    public partial class Settings: BaseEntity
    { 
        public int? LanguageID { get; set; }
        public int CountryID { get; set; }
        public int CurrencyID { get; set; }
        public string DocumentsAddress { get; set; }
        public int?  WarehouseDefaultID { get; set; }
        public int? DefaultPaymentMethodID { get; set; }
        public string StockLoteMode { get; set; }
        public bool? StockLevelNotification { get; set; }
        public bool? StockExpireDateNotification { get; set; }
        public int? StockStartAlertExpire { get; set; }
        public bool? StockAllowSalesValidLotes { get; set; }
        public string RestModality { get; set; }
        public int? StockIncomeSerieId { get; set; }
        public int? StockOutcomeSerieId { get; set; }
        public bool? SalesPriceChangePurchage { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
