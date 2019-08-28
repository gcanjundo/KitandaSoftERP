using KitandaSoftERP.Domain.Entities.Academica;
using KitandaSoftERP.Domain.Entities.MedicalManagement;
using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Entities.Worshop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class Customer : Entity
    {
        public int CustomerGroupID { get; set; }
        public virtual CustomerGroup CustomerGroup { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Student Student { get; set; }
        public ICollection<SalesInvoice> SalesInvoicesList { get; set; }
        public ICollection<CustomerReceipt> CustomerReceiptsList { get; set; }
        public ICollection<FeeManagementBillingSchedule> FeeManagementBillingScheduleList { get; set; }
        public ICollection<WorshopBooking> WorshopBookingList { get; set; }
        public ICollection<WorshopWorkorder> WorshopWorkOrderList { get; set; }
        public Customer():base()
        { 
            SalesInvoicesList = new HashSet<SalesInvoice>();
            CustomerReceiptsList = new HashSet<CustomerReceipt>();
            FeeManagementBillingScheduleList = new HashSet<FeeManagementBillingSchedule>();
            WorshopWorkOrderList = new HashSet<WorshopWorkorder>();
            WorshopBookingList = new HashSet<WorshopBooking>();
            Patient = new Patient();
            Student = new Student();
            CustomerGroup = new CustomerGroup();
        }
        public override bool IsValid()
        {
            ConfirmaValidacaoEmail();
            return !ErrorList.Any();
        }
    }
}
