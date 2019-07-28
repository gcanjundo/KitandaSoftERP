using KitandaSoftERP.Domain.Entities.Comercial;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Treasure
{
    public class CashBookMovimentSalesPayment
    {
        public int CashBookMovimentID { get; set; }
        public int DocumentTypeID { get; set; } 
        public int SalesRecepitInvoiceID { get; set; } // Invoice or Receipt AutoIncrement Field ID

        public virtual CashBookMoviment CashBookMoviment { get; set; }
        public virtual CommercialDocuments DocumentType { get; set; }

        public CashBookMovimentSalesPayment()
        {
            DocumentType = new CommercialDocuments();
            CashBookMoviment = new CashBookMoviment();
        }

    }
}
