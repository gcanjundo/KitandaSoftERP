using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class PaymentTerms : BaseEntity
    {
        public string PaymentTermsCode { get; set; }
        public int PaymentDeadLine { get; set; }
        public decimal InitialEntryValue { get; set; }
        public int ParcelNumbers { get; set; }
        public int Periodicity { get; set; }
        public decimal FinanceDiscount { get; set; } 
        public virtual ICollection<SalesInvoice> SalesInvoicesList { get; set; } 
        public PaymentTerms()
        {
            SalesInvoicesList = new HashSet<SalesInvoice>();
        }
        public override bool IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}
