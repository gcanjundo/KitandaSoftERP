using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class Customer : Entity
    {
        public ICollection<SalesInvoice> SalesInvoicesList { get; set; }
        public ICollection<FeeManagementBillingSchedule> FeeManagementBillingScheduleList { get; set; }
        public Customer():base()
        { 
            SalesInvoicesList = new HashSet<SalesInvoice>();
            FeeManagementBillingScheduleList = new HashSet<FeeManagementBillingSchedule>();
        }
        public override bool IsValid()
        {
            ConfirmaValidacaoEmail();
            return !ErrorList.Any();
        }
    }
}
