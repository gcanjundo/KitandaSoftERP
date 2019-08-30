using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Treasure
{
    public class BankEntities: EntityEnterprise
    {
        public int BankID { get; set; }
        public int BankType { get; set; }
        public virtual ICollection<BankAccounts> BankAccounts { get; set; }
        public virtual EntityEnterprise Enterprise { get; set; }
        public BankEntities()
        {
            BankAccounts = new HashSet<BankAccounts>();
            Enterprise = new EntityEnterprise();
        }
    }
}
