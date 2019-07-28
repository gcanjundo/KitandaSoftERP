using KitandaSoftERP.Domain.Entities.Shared;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Treasure
{

    public class BankAccounts : BaseEntity
    {
        public int AccountID { get; set; } 
        public string AccountNumber { get; set; }
        public int AccountBankID { get; set; }
        public int AccountOwnerID { get; set; }
        public string AccountType { get; set; }
        public string AccountNIB { get; set; }
        public string AccountIBAN { get; set; }
        public string AccountSWIFT { get; set; }
        public string AccountCurrencyID { get; set; } 
        public virtual BankEntities AccountBank { get; set; }

        public BankAccounts()
        {
            AccountBank = new BankEntities();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
