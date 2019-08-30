using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Treasure
{
    public class CashBookMoviment : BaseEntity
    {
        public int CashBookMovimentID { get; set; }
        public int CashBookMovimentBankAccountID { get; set; }
        public DateTime CashBookMovimentDate { get; set; }
        public DateTime CashBookMovimentRegisterDate { get; set; } 
        public int CashBookMovimentPaymentMethodID { get; set; }
        public string CashBookMovimentTransactType { get; set; }
        public int CashBookMovimentCashFlowID { get; set; }
        public decimal CashBookMovimentValue { get; set; }
        public int CashBookMovimentEntityID { get; set; }
        public int CashBookMovimentTresureSerialDocumentID { get; set; }
        public string CashBookMovimentReference { get; set; }
        public string CashBookMovimentExternReference { get; set; }
        public int CashBookMovimentNumber { get; set; }
        public bool CashBookMovimentConciled { get; set; }
        public bool CashBookMovimentIsReal { get; set; }

        public virtual BankAccounts CashBookMovimentBankAccount { get; set; }
        public virtual PaymentMethod CashBookMovimentPaymentMethod { get; set; }
        public virtual SerialCommercialDocuments CashBookMovimentTresureSerialDocument { get; set; }
        public virtual Entity CashBookMovimentEntity { get; set; }
        public virtual ICollection<CashBookMovimentSalesPayment> CashBookMovimentSalesPaymentList { get; set; }
        public CashBookMoviment()
        {
            CashBookMovimentBankAccount = new BankAccounts();
            CashBookMovimentPaymentMethod = new PaymentMethod();
            CashBookMovimentTresureSerialDocument = new SerialCommercialDocuments();
            CashBookMovimentEntity = new Entity();
            CashBookMovimentSalesPaymentList = new HashSet<CashBookMovimentSalesPayment>();
        }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
