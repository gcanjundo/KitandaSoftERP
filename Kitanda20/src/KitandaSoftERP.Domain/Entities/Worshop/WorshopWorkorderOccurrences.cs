using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.Worshop
{
    public partial class WorshopWorkorderOccurrences:BaseEntity
    { 
        public int? WorkOrderId { get; set; }
        public DateTime? IncidentDate { get; set; }
        public string IncidentType { get; set; }
        public int? IncidentTechnician { get; set; }
        public virtual WorshopEmployees Technician { get; set; }
        public virtual WorshopWorkorder WorkOrder { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
