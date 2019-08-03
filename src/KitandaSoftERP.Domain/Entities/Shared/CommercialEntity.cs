using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Shared
{
    public abstract class CommercialEntity:Entity
    {
        public decimal EntityCreditDeadLine { get; set; }
        public decimal EntityDiscount { get; set; }
        public int PaymentTermsID { get; set; }
        public int PaymentMethodID { get; set; }
        public decimal DiscountOnDocumentLines { get; set; }
        public int MaturityDays { get; set; }
        public int BalanceDeadLineDays { get; set; }
        public int CurrencyID { get; set; }
        public int SalesManID { get; set; }
        public int ChargesManID { get; set; }
        public int BankID { get; set; }
        public int BankAccountID { get; set; }
        public string IBAN { get; set; }
        public string SWIFT { get; set; }
        public string NIB { get; set; }
        public string CommercialContactName { get; set; }
        public string CommercialContactPhoneNumber { get; set; }
        public string ComercialContactEmail { get; set; }
        public int ExpeditionID { get; set; }
        public string ExpeditionBuildingNumber { get; set; }
        public string ExpeditionStreetName { get; set; }
        public string ExpeditionAddressDetail { get; set; }
        public int? ExpeditionCityID { get; set; }
        public int? ExpeditionDistrictCommuneID { get; set; }
        public string ExpeditionPostalCode { get; set; }
        public int? ExpeditionAddressProvinceID { get; set; }
        public int? ExpeditionAddressCountryID { get; set; } 
        public bool AllowBalanceAlert { get; set; }
        public int StartAlertDaysBefore { get; set; }
        public int StartAlertPeddingValueDaysBefore { get; set; }
        public int TaxRegimeID { get; set; }
        public int ManagementManID { get; set; }
        public int ReferralManID { get; set; }
        public bool AllowWithholding { get; set; }
        public bool SelfBilling { get; set; }
    }
}
