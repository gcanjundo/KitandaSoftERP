using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class CustomerReceiptInvoices : BaseEntity
    {
        public int CustomerRecepitInvoicesOrder { get; set; }
        public int CustomerReceiptID { get; set; }
        public int SalesInvoiceID { get; set; }
        public decimal InvoiceTotalNet { get; set; }
        public decimal InvoicePriorPedding { get; set; } 
        public decimal InvoiceTotalPaid { get; set; }
        public decimal DiscountFromPayment { get; set; }
        public decimal InvoicePenaties { get; set; }
        public decimal InvoiceNexPendding { get; set; } 
        public virtual CustomerReceipt CustomerReceipt { get; set; }
        public virtual SalesInvoice SalesInvoice { get; set; }
        public CustomerReceiptInvoices()
        {
            CustomerReceipt = new CustomerReceipt();
            SalesInvoice = new SalesInvoice();
        } 
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
