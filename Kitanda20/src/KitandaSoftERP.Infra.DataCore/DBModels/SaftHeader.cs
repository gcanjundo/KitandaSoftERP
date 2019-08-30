using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SaftHeader
    {
        public int TransactionId { get; set; }
        public string TransactionType { get; set; }
        public string AuditFileVersion { get; set; }
        public string CompanyId { get; set; }
        public string TaxRegistrationNumber { get; set; }
        public string TaxAccountingBasis { get; set; }
        public string CompanyName { get; set; }
        public string BusinessName { get; set; }
        public string BuildingNumber { get; set; }
        public string StreetName { get; set; }
        public string AddressDetail { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public int? FiscalYear { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string TaxEntity { get; set; }
        public string ProductCompanyTaxId { get; set; }
        public int? SoftwareValidationNumber { get; set; }
        public string ProductId { get; set; }
        public string ProductVersion { get; set; }
        public string HeaderComment { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
    }
}
