using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class StatusDocument : BaseEntity
    {
        public virtual ICollection<SalesInvoice> SalesInvoiceList { get; set; }

        public StatusDocument()
        {
            SalesInvoiceList = new HashSet<SalesInvoice>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
