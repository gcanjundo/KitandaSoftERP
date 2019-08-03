using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class SerialCommercialDocuments : BaseEntity
    {
        public int SerialCommercialDocumentID { get; set; }
        public int SerialCommercialDocumentTypeID { get; set; }
        public int SerialCommercialDocumentFiscalYearID { get; set; }
        public DateTime SerialCommercialDocumentInicialDate { get; set; }
        public DateTime SerialCommercialDocumentFinalDate { get; set; }
        public int LastNumber { get; set; } 
        public virtual ICollection<SalesInvoice> SalesInvoiceList { get; set; }
        public virtual FiscalYear FiscalYear { get; set; }
        public virtual Document SerialCommercialDocumentType { get; set; }
        public virtual ICollection<CashRegister> CashRegisterList { get; set; }
        public SerialCommercialDocuments():base()
        {
            SalesInvoiceList = new HashSet<SalesInvoice>();
            SerialCommercialDocumentType = new CommercialDocuments();
            CashRegisterList = new HashSet<CashRegister>();
            FiscalYear = new FiscalYear();
        }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
