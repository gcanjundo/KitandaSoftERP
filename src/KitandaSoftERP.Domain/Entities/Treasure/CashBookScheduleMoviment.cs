using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Treasure
{
    public partial class CashBookScheduleMoviment : BaseEntity
    { 
        public DateTime CashBookScheduleMovimentStartDate { get; set; }
        public DateTime CashBookScheduleMovimentEndDate { get; set; }
        public string CashBookScheduleMovimentFrequency { get; set; }
        public int CashBookScheduleMovimentDays { get; set; }
        public string CashBookScheduleMovimentTransactionType { get; set; } // Debit or Credit 
        public decimal CashBookScheduleMovimentAmount { get; set; }
        public decimal? CashBookScheduleMovimentExchange { get; set; }
        public bool Excuted { get; set; }
        public int? CashBookScheduleMovimentSerialDocumentID { get; set; }
        public int? CashBookScheduleMovimentBankAccountID { get; set; }
        public int CashBookScheduleMovimentEntityID { get; set; }
        public int? CashBookScheduleMovimentFinanceHeadingID { get; set; }
        public int CashBookScheduleMovimentCurrencyID { get; set; }
        public virtual SerialCommercialDocuments CashBookScheduleMovimentSerialDocument { get; set; }
        public virtual BankAccounts CashBookScheduleMovimentBankAccount { get; set; }
        public virtual Entity CashBookScheduleMovimentEntity { get; set; }
        //public virtual CashBookScheduleMovimentFinanceHeading { get; set; }
        public virtual Currency CashBookScheduleMovimentCurrency { get; set; }
        public CashBookScheduleMoviment()
        {
            CashBookScheduleMovimentSerialDocument = new SerialCommercialDocuments();
            CashBookScheduleMovimentBankAccount = new BankAccounts();
            CashBookScheduleMovimentEntity = new Entity();
            CashBookScheduleMovimentCurrency = new Currency();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
