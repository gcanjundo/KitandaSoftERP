using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class CustomerReceipt : BaseEntity
    {
        public int CustomerReceiptID { get; set; }
        public int SerialDocumentID { get; set; }
        public int CustomerID { get; set; }
        public int OriginDocumentTypeID { get; set; }
        public int OriginDocumentID { get; set; }
        public int TaxID { get; set; }
        public int CurrencyID { get; set; }
        public DateTime ReceiptDate { get; set; }
        public string ReceiptReference { get; set; }
        public int ReceiptNumber { get; set; } 
        public decimal Exchange { get; set; } 
        public decimal Discount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal NetTotal { get; set; }
        public decimal TotalPaid { get; set; }
        public string AbortReason { get; set; }
        public string Barcode { get; set; } 
        public virtual TaxTable Tax { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual SerialCommercialDocuments DocumentSerial { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual CommercialDocuments OriginDocumentType { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
