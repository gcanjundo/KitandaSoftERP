using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public partial class CustomerGroup : BaseEntity
    {
        public virtual ICollection<Customer> CustomerList { get; set; }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
