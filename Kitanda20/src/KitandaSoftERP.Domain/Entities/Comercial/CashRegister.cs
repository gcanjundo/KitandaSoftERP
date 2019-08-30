using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Entities.Stock;
using KitandaSoftERP.Domain.Entities.Treasure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class CashRegister : BaseEntity
    {
        public int CashRegisterID { get; set; }
        public int DefaultWarehouseID { get; set; }
        public int SerialDocumentID { get; set; }
        public int CustomerID { get; set; }
        public int DefaultPaymentMethodID { get; set; }
        public int DefaultAccountID { get; set; }
        public int OwnerUserID { get; set; }
        public int DefaultPaymentTermsID { get; set; }
        public decimal CashFundValue { get; set; }
        public int CashRefundSerieID { get; set; }
        public int CreditRefundSerieID { get; set; } 
        public virtual Warehouse DefaultWarehouse { get; set; }
        public virtual SerialCommercialDocuments SerialDocument { get; set; }
        public virtual SerialCommercialDocuments CashRefundSerie { get; set; }
        public virtual SerialCommercialDocuments CreditRefundSerie { get; set; }
        public virtual PaymentMethod DefaultPaymentMethod { get; set; }
        public virtual BankAccounts DefaultBankAccount { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual User OwnUser { get; set; }
        public virtual PaymentTerms DefaultPaymentTerms { get; set; }
        public virtual ICollection<CashRegisterMoviment> CashRegisterList { get; set; }
        public CashRegister()
        {
            Customer = new Customer();
            OwnUser = new User();
            DefaultBankAccount = new BankAccounts();
            DefaultPaymentMethod = new PaymentMethod();
            SerialDocument = new SerialCommercialDocuments();
            DefaultWarehouse = new Warehouse();
            DefaultPaymentTerms = new PaymentTerms();
            CashRegisterList = new HashSet<CashRegisterMoviment>();
            CashRefundSerie = new SerialCommercialDocuments();
            CreditRefundSerie = new SerialCommercialDocuments();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
