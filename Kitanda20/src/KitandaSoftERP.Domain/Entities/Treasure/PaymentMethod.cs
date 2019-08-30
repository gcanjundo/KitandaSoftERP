using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Treasure
{
    public class PaymentMethod:BaseEntity
    {
        public int PaymentMethodID { get; set; }
        public string PaymentMethodOutcomeDesignation { get; set; }
        public string PaymentMethodOutcomeDesignationOtherLanguage { get; set; }
        public bool PaymentMethodPOSVisible { get; set; }
        public int PaymentMethodBankAccountID { get; set; }
        public bool PaymentMethodAllowChange { get; set; }
        public string PaymentMethodType { get; set; }
        
        public virtual ICollection<CashBookMoviment> CashBookMovimentList { get; set; }
        public virtual ICollection<CashRegister> CashRegisterList { get; set; }

        public PaymentMethod()
        {
            CashBookMovimentList = new HashSet<CashBookMoviment>();
            CashRegisterList = new HashSet<CashRegister>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
