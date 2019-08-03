using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class FeeManagementBillingSchedule
    {
        public int FeeManagementBillingScheduleID { get; set; }
        public int FeeManagementID { get; set; }
        public int CustomerID { get; set; }
        public DateTime ScheduleDate { get; set; }
        public DateTime PaymentExpectedDate { get; set; }
        public DateTime PaymentDeadLine { get; set; }
        public int Month { get; set; }
        public decimal ExpectedAmount { get; set; }
        public int InvoiceID { get; set; }        
        public virtual FeeManagement FeeManagement { get; set; }
        public virtual SalesInvoice Invoice { get; set; }
        public virtual Customer Customer { get; set; }
        public FeeManagementBillingSchedule()
        {
            FeeManagement = new FeeManagement();
            Invoice = new SalesInvoice();
            Customer = new Customer();
        }
    }
}
