using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Worshop
{
    public partial class WorshopEmployees:Entity
    {
        public int DepartmentID { get; set; }
        public virtual ICollection<WorshopWorkorder> WorkOrderList { get; set; }
    }
}
