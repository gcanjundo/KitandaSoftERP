using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Entities.Treasure;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Comercial
{

    public class CommercialDocuments : Document
    {
        public string SourceTable { get; set; }
        public ICollection<SerialCommercialDocuments> SerialCommercialDocumentsList { get; set; }
        public ICollection<CustomerReceipt> OriginDocumentTypeList { get; set; }
        public ICollection<SalesInvoice> SalesInvoiceOriginTypeDocumentList { get; set; }
        public virtual ICollection<CashBookMovimentSalesPayment> CashBookMovimentSalesPaymentList { get; set; }
        public CommercialDocuments()
        {
            SerialCommercialDocumentsList = new HashSet<SerialCommercialDocuments>();
            CashBookMovimentSalesPaymentList = new HashSet<CashBookMovimentSalesPayment>();
            OriginDocumentTypeList = new HashSet<CustomerReceipt>();
            SalesInvoiceOriginTypeDocumentList = new HashSet<SalesInvoice>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
