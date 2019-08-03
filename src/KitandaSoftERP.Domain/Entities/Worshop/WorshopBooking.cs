using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Entities.Geral;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Worshop
{
    public partial class WorshopBooking:BaseEntity
    {
        public WorshopBooking()
        {
            WorshopWorkorder = new WorshopWorkorder();
            Service = new WorshopProduct();
            Document = new CommercialDocuments();
            Vehicle = new Vehicle();
            BillingEntity = new Customer();
        } 
        
        public DateTime? MarCheckIn { get; set; }
        public int VehicleId { get; set; }
        public int? DocumentId { get; set; }
        public int? ServiceId { get; set; }
        public int? BillingEntityId { get; set; } 
        public string CancelNotes { get; set; } 
        public int? CheckinBranchId { get; set; }  
        public virtual Customer BillingEntity { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual Document Document { get; set; }
        public virtual WorshopProduct Service { get; set; }
        public virtual WorshopWorkorder WorshopWorkorder { get; set; }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
