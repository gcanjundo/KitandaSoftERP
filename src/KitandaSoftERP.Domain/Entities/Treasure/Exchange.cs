using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Treasure
{
    public class Exchange : BaseEntity
    {
        public int CurrencyID { get; set; }
        public int BankEntityID { get; set; }
        public decimal ExchangeAmount { get; set; }
        public DateTime ExchangeStartDate { get; set; }
        public DateTime ExchangeEndDate { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual BankEntities BankEntity { get; set; }

        public Exchange()
        {
            Currency = new Currency();
            BankEntity = new BankEntities();
        }
        public override bool IsValid()
        {
            return ErrorList.Any();
        }
    }
}
