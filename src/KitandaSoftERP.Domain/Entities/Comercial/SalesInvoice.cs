

using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Entities.Stock;
using KitandaSoftERP.Domain.Shared.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class SalesInvoice : BaseEntity
    {
        public int SalesInvoiceID { get; set; }
        public int SalesInvoiceOrderNumber { get; set; }
        public string SalesInvoiceReference { get; set; }
        public DateTime SalesInvoiceDate { get; set; }
        public int SalesInvoicePaymentTermsID { get; set; }
        public int SalesInvoiceCustomerID { get; set; }
        public DateTime SalesInvoiceDueDate { get; set; }
        public int SalesInvoicePaymentStatusID { get; set; }
        public int SalesInvoiceSerialDocumentID { get; set; }
        public int SalesInvoiceComercialStatusID { get; set; } 
        public int SalesInvoiceBillingEntityID { get; set; } 
        public string SalesInvoiceHash { get; set; }
        public string SalesInvoiceHashControl { get; set; }
        public string SalesInvoiceBarcode { get; set; }
        public decimal SalesInvoiceNetTotal { get; set; }
        public decimal SalesInvoiceTaxPayble { get; set; }
        public decimal SalesInvoiceDiscountAmountTotal { get; set; }
        public decimal SalesInvoiceGrossTotal { get; set; }
        public decimal SalesInvoiceCreditTotal { get; set; }
        public decimal SalesInvoiceCommercialDiscount { get; set; }
        public decimal SalesInvoiceCustomerDiscount { get; set; }
        public decimal SalesInvoiceFinanceDiscount { get; set; }
        public decimal SalesInvoiceTotalPaid { get; set; }
        public decimal SalesInvoiceTotalPending { get; set; }
        public int SalesInvoiceWareHouseID { get; set; }
        public int SalesInvoiceCurrencyID { get; set; }
        public decimal SalesInvoiceExchange { get; set; }
        public decimal SalesInvoiceExpeditionID { get; set; }
        public string SalesInvoiceInternalNotes { get; set; }
        public string SalesInvoiceRetificationReason { get; set; }
        public int SalesInvoiceOriginTypeDocumentID { get; set; }
        public int SalesInvoiceOriginDocumentID { get; set; }
        public DateTime SalesInvoiceShipFromDate { get; set; }
        public int SalesInvoiceShipFromWarehouseID { get; set; } 
        public Address SalesInvoiceShipFromAddress { get; set; }
        public DateTime SalesInvoiceShipToDate { get; set; }
        public string SalesInvoiceShipToLocation { get; set; }
        public Address SalesInvoiceShipToAddress { get; set; }
        public int SalesInvoiceParcelNumber { get; set; }
        public decimal SalesInvoiceRetentionAmount { get; set; }
        public bool SalesInvoicePaid { get; set; }
        public bool SalesInvoiceRectified { get; set; }
        public int SalesInvoiceSaftExportID { get; set; }
        public bool SalesInvoiceCustomerSent { get; set; }
        public string SalesInvoiceCustomerSentBy { get; set; }
        public DateTime SalesInvoiceCustomerSentDate { get; set; }
        public bool SalesInvoiceAGTSent { get; set; }
        public string SalesInvoiceAGTSentBy { get; set; }
        public DateTime SalesInvoiceAGTSentDate { get; set; }
        public bool SalesInvoiceSourceBilling { get; set; } 
        public virtual Customer SalesInvoiceCustomer { get; set; }
        public virtual PaymentTerms SalesInvoicePaymentTerms { get; set; }
        public virtual SerialCommercialDocuments SalesInvoiceSerialDocument { get; set; }
        public virtual Warehouse SalesInvoiceWarehouse { get; set; }
        public virtual Customer SalesInvoiceBillingEntity { get; set; }
        public virtual StatusDocument SalesInvoiceStatusDocment { get; set; }
        public virtual StatusPayment SalesInvoiceStatusPayment { get; set; }
        public virtual Currency SalesInvoiceCurrency { get; set; }  
        public ICollection<SalesInvoiceLines> SalesInvoicesLines { get; set; }

        public SalesInvoice()
        {
            SalesInvoiceCustomer = new Customer();
            SalesInvoicePaymentTerms = new PaymentTerms();
            SalesInvoiceSerialDocument = new SerialCommercialDocuments();
            SalesInvoiceWarehouse = new Warehouse();
            SalesInvoiceBillingEntity = new Customer();
            SalesInvoiceStatusDocment = new StatusDocument();
            SalesInvoiceStatusPayment = new StatusPayment();
            SalesInvoiceCurrency = new Currency();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
